using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace POManager
{
    public partial class PO_Viewer : Form
    {
        Image image = null;
        public PO_Viewer()
        {
            InitializeComponent();
        }

        public PO_Viewer(String acceptNum, String country, int gubun, String date,String poNum,String seller,String sellerAdd,String deliveryCondition,
                        String paymentCondition, String expactdateRequest, String dateRequest, String penalty,
                        String bigo, String m_strPath, ArrayList dategrid, String totalAumount,
                        String seller_name, String seller_tel, String seller_fax)
        {
            InitializeComponent();
            String loadurl = m_strPath;
            Image imageFile = Image.FromFile(loadurl);
            Graphics grfx = Graphics.FromImage(imageFile);

            Font font = new Font("굴림", 10);
            Font font1 = new Font("굴림", 8, FontStyle.Bold);
            Font font2 = new Font("굴림", 13, FontStyle.Bold);
            Font font3 = new Font("굴림", 12, FontStyle.Bold);
            Brush brush = Brushes.Black;

            if (gubun == 1)//AiMS 한글
            {
                int y = 445;

                grfx.DrawString(acceptNum, font2, brush, 650, 70);
                grfx.DrawString(date, font2, brush, 550, 185);
                grfx.DrawString(poNum, font2, brush, 588, 215);
                grfx.DrawString(seller, font2, brush, 99, 314);
                grfx.DrawString(sellerAdd, font2, brush, 99, 340);
                grfx.DrawString(seller_name, font2, brush, 99, 360);
                grfx.DrawString("Tel: "+seller_tel, font2, brush, 200, 360);
                grfx.DrawString("Fax. "+seller_fax, font2, brush, 350, 360);

                IEnumerator enu = dategrid.GetEnumerator();
                while (enu.MoveNext())
                {
                    string[] split = null;
                    String partsList = enu.Current.ToString();
                    split = partsList.Split('+');
                    String partNum = split[0];
                    String maker = split[1];
                    int makerlength = split[2].Trim().Length;
                    String makerPN;
                    String makerPN1;
                    //String makerPN1 = split[2]; 
                    if (makerlength < 15)
                    {
                        makerPN = split[2];
                        makerPN1 = "";
                    }
                    else
                    {
                        makerPN = split[2].Substring(0, 15);
                        makerlength -= 15;
                        makerPN1 = split[2].Substring(15, makerlength);
                    }                   

                    String quentity = split[3];
                    String unitAumount = MoneyString(split[4]);
                    String aumont = MoneyString(split[5]);

                    grfx.DrawString(partNum, font, brush, 111, y);
                    grfx.DrawString(maker, font, brush, 244, y);
                    grfx.DrawString(makerPN, font1, brush, 367, y);
                    grfx.DrawString(makerPN1, font1, brush, 367, y + 10);
                    grfx.DrawString(quentity, font, brush, 526, y);
                    grfx.DrawString(unitAumount, font, brush, 594, y);
                    grfx.DrawString(aumont, font, brush, 708, y);
                    y += 25;
                }
                grfx.DrawString(deliveryCondition, font2, brush, 150, 892);
                grfx.DrawString(paymentCondition, font2, brush, 150, 917);
                grfx.DrawString(expactdateRequest, font2, brush, 150, 945);
                grfx.DrawString(dateRequest, font2, brush, 150, 973);
                grfx.DrawString(penalty, font2, brush, 150, 997);
                grfx.DrawString(bigo, font2, brush, 150, 1025);
                grfx.DrawString(totalAumount, font2, brush, 725, 835);

            }
            else if(gubun == 2)//AiMS 영문
            {
                int y = 490;

                grfx.DrawString(acceptNum, font2, brush, 720, 70);
                grfx.DrawString(country, font2, brush, 109, 178);
                grfx.DrawString(date, font2, brush, 690, 165);
                grfx.DrawString(poNum, font2, brush, 720, 186);
                grfx.DrawString(seller, font2, brush, 95, 335);
                grfx.DrawString(sellerAdd, font2, brush, 95,362);
                grfx.DrawString(seller_name, font2, brush, 95, 385);
                grfx.DrawString("Tel: " + seller_tel, font2, brush, 190, 385);
                grfx.DrawString("Fax. " + seller_fax, font2, brush, 340, 385);

                IEnumerator enu = dategrid.GetEnumerator();
                while (enu.MoveNext())
                {
                    string[] split = null;
                    String partsList = enu.Current.ToString();
                    split = partsList.Split('+');
                    String partNum = split[0];
                    String maker = split[1];
                    String makerPN = split[2];
                    String quentity = split[3];
                    String unitAumount = MoneyString(split[4]);
                    String aumont = MoneyString(split[5]);

                    grfx.DrawString(partNum, font, brush, 111, y);
                    grfx.DrawString(maker, font, brush, 244, y);
                    grfx.DrawString(makerPN, font, brush, 367, y);
                    grfx.DrawString(quentity, font, brush, 590, y);
                    grfx.DrawString(unitAumount, font, brush, 650, y);
                    grfx.DrawString(aumont, font, brush, 758, y);
                    y += 25;
                }
                grfx.DrawString(deliveryCondition, font2, brush, 200, 932);
                grfx.DrawString(paymentCondition, font2, brush, 200, 957);
                //grfx.DrawString(expactdateRequest, font2, brush, 200, 985);
                grfx.DrawString(dateRequest, font2, brush, 220, 985);
                grfx.DrawString(penalty, font2, brush, 150, 1007);
                grfx.DrawString(bigo, font2, brush, 120, 1035);
                grfx.DrawString(totalAumount, font2, brush, 750, 878);
            }
            else if (gubun == 3)//AsTek 한글
            {
                int y = 450;

                grfx.DrawString(acceptNum, font2, brush, 750, 65);
                grfx.DrawString(date, font2, brush, 550, 195);
                grfx.DrawString(poNum, font2, brush, 588, 225);
                grfx.DrawString(seller, font2, brush, 99, 324);
                grfx.DrawString(sellerAdd, font2, brush, 99, 350);
                grfx.DrawString(seller_name, font2, brush, 99, 370);
                grfx.DrawString("Tel: " + seller_tel, font2, brush, 180, 370);
                grfx.DrawString("Fax. " + seller_fax, font2, brush, 330, 370);

                IEnumerator enu = dategrid.GetEnumerator();
                while (enu.MoveNext())
                {
                    string[] split = null;
                    String partsList = enu.Current.ToString();
                    split = partsList.Split('+');
                    String partNum = split[0];
                    String maker = split[1];
                    String makerPN = split[2];
                    String quentity = split[3];
                    String unitAumount = MoneyString(split[4]);
                    String aumont = MoneyString(split[5]);

                    grfx.DrawString(partNum, font, brush, 111, y);
                    grfx.DrawString(maker, font, brush, 244, y);
                    grfx.DrawString(makerPN, font1, brush, 367, y);
                    grfx.DrawString(quentity, font, brush, 526, y);
                    grfx.DrawString(unitAumount, font, brush, 594, y);
                    grfx.DrawString(aumont, font, brush, 708, y);
                    y += 25;
                }
                grfx.DrawString(deliveryCondition, font2, brush, 150, 892);
                grfx.DrawString(paymentCondition, font2, brush, 150, 917);
                grfx.DrawString(expactdateRequest, font2, brush, 150, 945);
                grfx.DrawString(dateRequest, font2, brush, 150, 973);
                grfx.DrawString(penalty, font2, brush, 150, 997);
                grfx.DrawString(bigo, font2, brush, 150, 1025);
                grfx.DrawString(totalAumount, font3, brush, 725, 840);
            }
            else// AiMS 영문
            {
                int y = 490;
                grfx.DrawString(acceptNum, font2, brush, 720, 55);
                grfx.DrawString(country, font2, brush, 109, 176);
                grfx.DrawString(date, font2, brush, 690, 160);
                grfx.DrawString(poNum, font2, brush, 720, 182);
                grfx.DrawString(seller, font2, brush, 95, 335);
                grfx.DrawString(sellerAdd, font2, brush, 95, 362);
                grfx.DrawString(seller_name, font2, brush, 95, 385);
                grfx.DrawString("Tel: " + seller_tel, font2, brush, 180, 385);
                grfx.DrawString("Fax. " + seller_fax, font2, brush, 330, 385);

                IEnumerator enu = dategrid.GetEnumerator();
                while (enu.MoveNext())
                {
                    string[] split = null;
                    String partsList = enu.Current.ToString();
                    split = partsList.Split('+');
                    String partNum = split[0];
                    String maker = split[1];
                    String makerPN = split[2];
                    String quentity = split[3];
                    String unitAumount = MoneyString(split[4]);
                    String aumont = MoneyString(split[5]);

                    grfx.DrawString(partNum, font, brush, 111, y);
                    grfx.DrawString(maker, font, brush, 244, y);
                    grfx.DrawString(makerPN, font, brush, 367, y);
                    grfx.DrawString(quentity, font, brush, 590, y);
                    grfx.DrawString(unitAumount, font, brush, 650, y);
                    grfx.DrawString(aumont, font, brush, 758, y);
                    y += 25;
                }
                grfx.DrawString(deliveryCondition, font2, brush, 200, 932);
                grfx.DrawString(paymentCondition, font2, brush, 200, 957);
                //grfx.DrawString(expactdateRequest, font2, brush, 200, 985);
                grfx.DrawString(dateRequest, font2, brush, 220, 985);
                grfx.DrawString(penalty, font2, brush, 150, 1007);
                grfx.DrawString(bigo, font2, brush, 120, 1035);
                grfx.DrawString(totalAumount, font2, brush, 750, 878);
            }
            grfx.Dispose();
           
            imageFile.Save("C:\\OP_Form\\save\\" + poNum + ".png", System.Drawing.Imaging.ImageFormat.Png);
            
           
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics grfx = e.Graphics;
            if (image != null)
                grfx.DrawImage(image, 0, 0);
        }

        private string MoneyString(string str)
        {
            string result = str;
            for (int i = str.Length - 3; i > 0; i = i - 3)
            {
                result = result.Insert(i, ",");

            }

            return result;
        }
    }
}
