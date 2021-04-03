﻿/*
Student Name: Yuriko Uchida
Student Number: #200448500

Due Date: April 7, 2021
Lab 2
*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2_Winter2021
{
    public partial class Lab2 : Form
    {


        public Lab2()
        {
            InitializeComponent();
        }

        
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            maskedTextBoxMemberId.Text = "";
        }


        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            String name = textBoxName.Text;
            String id = maskedTextBoxMemberId.Text;

            if (name != null && id.Length == 4)
            {
                //Name and ID forms will be invisible
                labelName.Visible = false;
                textBoxName.Visible = false;
                labelMemberId.Visible = false;
                maskedTextBoxMemberId.Visible = false;

                //Button availability will be switched
                buttonSignIn.Enabled = false;
                buttonPrint.Enabled = true;
                buttonClear.Enabled = false;

                //Following properties will enable
                richTextBoxWelcome.Visible = true;
                textBoxPromotion.Visible = true;
                groupDepartment.Enabled = true;
                pictureBoxDepartment.Visible = true;
                checkBoxImageVisible.Visible = true;
                richTextBoxWelcome.Text = "Welcome " + name + "!\nYour member ID: " + id;
            }
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Exit the application
            this.Close();
        }


        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //PrintPageイベントハンドラの追加
            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument_PrintPage);
            //印刷を開始する
            printDocument.Print();
        }


        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //画像を読み込む
            Image img = Image.FromFile("test.bmp");
            //画像を描画する
            e.Graphics.DrawImage(img, e.MarginBounds);
            //次のページがないことを通知する
            e.HasMorePages = false;
            //後始末をする
            img.Dispose();
        }

        private void radioClothing_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPromotion.Text = "All items are 10% OFF now!";
            if (checkBoxImageVisible.Checked)
            {
                pictureBoxDepartment.Image = Properties.Resources.clothing;
            }
            else
            {
                pictureBoxDepartment.Image = null;
            }
        }



        private void radioEquipment_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPromotion.Text = "Weight training tools, yoga mat, balance balls, etc";
            if (checkBoxImageVisible.Checked)
            {
                pictureBoxDepartment.Image = Properties.Resources.accessories;
            }
            else
            {
                pictureBoxDepartment.Image = null;
            }
        }


        private void radioJuiceBar_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPromotion.Text = "Fresh fruit juice at Juice Bar";
            if (checkBoxImageVisible.Checked)
            {
                pictureBoxDepartment.Image = Properties.Resources.juice_bar;
            }
            else
            {
                pictureBoxDepartment.Image = null;
            }
        }

        private void radioMembership_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPromotion.Text = "You are welcome to join our membership";
            if (checkBoxImageVisible.Checked)
            {
                pictureBoxDepartment.Image = Properties.Resources.membership;
            }
            else
            {
                pictureBoxDepartment.Image = null;
            }
        }


        private void radioPersonalTraining_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPromotion.Text = "Everyday available from 8 AM to 9 PM";
            if (checkBoxImageVisible.Checked)
            {
                pictureBoxDepartment.Image = Properties.Resources.personal_training;
            }
            else
            {
                pictureBoxDepartment.Image = null;
            }
        }

        private void checkBoxImageVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxImageVisible.Checked)
            {
                pictureBoxDepartment.Image = null;
            }
            else
            {




                pictureBoxDepartment.Image = null;


            }

        }
    }
}
