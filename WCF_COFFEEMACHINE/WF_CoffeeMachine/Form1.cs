using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WF_CoffeeMachine
{
    public partial class Form1 : Form
    {

        static int qtSucre=1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

     

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool cdt=false;
            RadioButton currentRadioButton=new RadioButton();
            for (int i = 1; i <=5 && cdt==false; i++)
            {
                foreach (Control c in panel1.Controls.Find("checkBox" + (i + 1), true))
                {
                    switch (i)
                    {
                        case 1:
                            {
                                cdt = (checkBox2.Checked == false) ? checkBox2.Checked = true : false;
                                qtSucre =2;
                                    break;
                            }
                        case 2:
                            {
                                cdt = (checkBox3.Checked == false) ? checkBox3.Checked = true : false;
                                qtSucre =3;
                                    break;
                            }
                        case 3:
                            {
                                cdt = (checkBox4.Checked == false) ? checkBox4.Checked = true : false;
                                qtSucre =4;
                                    break;

                            }
                        case 4:
                            {
                                cdt = (checkBox5.Checked == false) ? checkBox5.Checked = true : false;
                                qtSucre =5;
                                    break;
                            }
                    }
                          }
            }

        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)     
        {
            bool cdt = true;
            for (int i = 5; i >= 2 && cdt == true; i--)
            {
                foreach (Control c in panel1.Controls.Find("checkBox" + (i), true))
                {
                    switch (i)
                    {
                        case 5:
                            {
                                cdt = (checkBox5.Checked == true) ? checkBox5.Checked = false : true;
                                qtSucre =4;
                                break;
                            }
                        case 4:
                            {
                                cdt = (checkBox4.Checked == true) ? checkBox4.Checked = false : true;
                                qtSucre =3;
                                break;
                            }
                        case 3:
                            {
                                cdt = (checkBox3.Checked == true) ? checkBox3.Checked = false : true;
                                qtSucre =2;
                                break;

                            }
                        case 2:
                            {
                                cdt = (checkBox2.Checked == true) ? checkBox2.Checked = false : true;
                                qtSucre =1;
                                break;
                            }
                    }
                }
            }
             
        }



       /// <summary>
       /// Selectionner la boisson passée en paramétre
       /// </summary>
       /// <param name="type_drink"></param>
       /// <returns>true=> la boisson trouvée dans le menu / false => sinon</returns>
       bool write_type_drink(string type_drink)
        {       
           switch( type_drink)
           {
               case datas.type_drink.blackcoffee  : { radioButton1.Checked = true; return true; }
               case datas.type_drink.coffeewithmilk : { radioButton2.Checked = true; return true; }
               case datas.type_drink.naturetea : { radioButton3.Checked = true; return true; }
               case datas.type_drink.milkchocolate : { radioButton4.Checked = true; return true; }
           }
           return false;
        }


        string read_type_drink()
        {
           
            RadioButton _radiobutton;
            for (int i = 1; i<=4 ;i++)
            {
                foreach (Control radioButton in panel1.Controls.Find("radioButton" + (i), true))
                {
                    _radiobutton = (RadioButton)radioButton;
                    if (_radiobutton.Checked == true)
                        return _radiobutton.Text;
                }
            }
            return null;
        }

        void write_qtSucre(int qtsucre)
        {

            for (int i = 1; i <= qtsucre; i++)
            {
                foreach (CheckBox c in panel1.Controls.Find("checkBox" + (i + 1), true))
                {
                    c.Checked = true;
                }
            }
            for (int i = datas.type_drink.maxqtSucre ; i> qtsucre; i--)
            {
                foreach (CheckBox c in panel1.Controls.Find("checkBox" + (i), true))
                {
                    c.Checked = false;
                }
            }
           
        }

        int read_qtSucre()
        {
              return qtSucre;
        }

        void write_mug(byte choiceMug)
        {
            checkBox6.Checked = Convert.ToBoolean(choiceMug);
        }


        byte read_mug()
        {
          return Convert.ToByte(checkBox6.Checked);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "";
                label3.Visible = true;
                this.Cursor = Cursors.WaitCursor;
                datas data = datas.instance();
                datas._customer.id_customer = Convert.ToInt32(textBox1.Text);
                datas._customer.type_drink = read_type_drink();
                datas._customer.qtsucre = read_qtSucre();
                datas._customer.mug = read_mug();
                Application.DoEvents();
                label3.Text = "Votre boisson est en cours ...";
                data.insertCustomer();
                Thread.Sleep(3000);
                label3.Text = "Votre boisson est préte.";
                this.Cursor = Cursors.WaitCursor;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.WaitCursor;
            }
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           int i = 0;
           if (int.TryParse(textBox1.Text, out i))
           {
               this.Cursor = Cursors.WaitCursor;
               datas data = datas.instance();
               datas._customer.id_customer = Convert.ToInt32(textBox1.Text);
               datas._Customer cst = data.seachCustomer();
               write_type_drink(cst.type_drink);
               write_qtSucre(cst.qtsucre);
               write_mug(cst.mug);
               this.Cursor = Cursors.Default;
           }

        }
    }
}
