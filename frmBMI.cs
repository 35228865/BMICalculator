using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class frmBMI : Form
    {
        public frmBMI()
        {
            InitializeComponent();
        }
        private List<string> bmiHistory = new List<string>();
        private readonly string historyFilePath = Application.StartupPath + "\\bmi_history.txt";

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (System.IO.File.Exists(historyFilePath))
            {
                bmiHistory.AddRange(System.IO.File.ReadAllLines(historyFilePath));
            }
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHeight.Text) || string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                MessageBox.Show("請輸入身高與體重");
                return;
            }


            double height, weight;
            if (!double.TryParse(txtHeight.Text, out height) || !double.TryParse(txtWeight.Text, out weight))
            {
                MessageBox.Show("請輸入正確的數字格式");
                return;
            }

            if (height <= 0 || weight <= 0)
            {
                MessageBox.Show("身高與體重必須為正數");
                return;
            }

            height = height / 100;
            double bmi = weight / (height * height);
            string resultText = $"{bmi:F2}";
            string status = "";

            if (bmi < 18.5)
            {
                status = "過輕";
                lblResult.Text = $"{resultText}，{status}";
                lblResult.BackColor = Color.Blue;
            }
            else if (bmi < 24)
            {
                status = "健康";
                lblResult.Text = $"{resultText}，{status}";
                lblResult.BackColor = Color.Green;
            }
            else if (bmi < 27)
            {
                status = "過重";
                lblResult.Text = $"{resultText}，{status}";
                lblResult.BackColor = Color.Yellow;
            }
            else if (bmi < 30)
            {
                status = "輕度肥胖";
                lblResult.Text = $"{resultText}，{status}";
                lblResult.BackColor = Color.Orange;
            }
            else if (bmi < 35)
            {
                status = "中度肥胖";
                lblResult.Text = $"{resultText}，{status}";
                lblResult.BackColor = Color.OrangeRed;
            }
            else if (bmi >= 35)
            {
                status = "重度肥胖";
                lblResult.Text = $"{resultText}，{status}";
                lblResult.BackColor = Color.Red;
            }

            string record = $"時間: {DateTime.Now:yyyy/MM/dd HH:mm:ss}，身高: {height * 100} cm，體重: {weight} kg，BMI: {resultText}，狀態: {status}";
            bmiHistory.Add(record);
            System.IO.File.AppendAllText(historyFilePath, record + Environment.NewLine);
        }

        private void 過往紀錄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bmiHistory.Count == 0)
            {
                MessageBox.Show("目前沒有任何紀錄。");
                return;
            }

            frmRecord historyForm = new frmRecord(bmiHistory);
            historyForm.ShowDialog();
        }

    }
}

