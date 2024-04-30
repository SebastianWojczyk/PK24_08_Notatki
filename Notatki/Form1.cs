using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatki
{
    public partial class Form1 : Form
    {
        DBDataContext dbdc = new DBDataContext();
        public Form1()
        {
            InitializeComponent();
            listBoxPages.DisplayMember = "Title";
            LoadPagesList();
            if (listBoxPages.Items.Count > 0)
            {
                listBoxPages.SelectedIndex = 0;
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Page newPage = new Page();
            newPage.Title = "Nowa strona";

            dbdc.Pages.InsertOnSubmit(newPage);
            dbdc.SubmitChanges();

            LoadPagesList();

            listBoxPages.SelectedItem = newPage;
        }
        private void LoadPagesList()
        {
            listBoxPages.Items.Clear();
            listBoxPages.Items.AddRange(dbdc.Pages.ToArray());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxPages.SelectedItem is Page)
            {
                Page p = listBoxPages.SelectedItem as Page;
                foreach (Shape s in p.Shapes)
                {
                    dbdc.Points.DeleteAllOnSubmit(s.Points);
                }
                dbdc.Shapes.DeleteAllOnSubmit(p.Shapes);
                dbdc.Pages.DeleteOnSubmit(p);
                dbdc.SubmitChanges();

                LoadPagesList();
                if (listBoxPages.Items.Count > 0)
                {
                    listBoxPages.SelectedIndex = 0;
                }
            }
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPages.SelectedItem is Page)
            {
                Page p = listBoxPages.SelectedItem as Page;
                textBoxTitle.Text = p.Title;
                LoadImage();
            }
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            if (listBoxPages.SelectedItem is Page)
            {
                Page p = listBoxPages.SelectedItem as Page;
                p.Title = textBoxTitle.Text;

                dbdc.SubmitChanges();

                LoadPagesList();

                listBoxPages.SelectedItem = p;
            }
        }

        private void pictureBoxPage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (listBoxPages.SelectedItem is Page)
                {
                    Page p = listBoxPages.SelectedItem as Page;

                    newShape = new Shape();
                    newShape.Color = buttonPenColor.BackColor.ToArgb();
                    newShape.Width = (int)numericUpDownPenWidth.Value;

                    Point p1 = new Point();
                    p1.X = e.X;
                    p1.Y = e.Y;

                    newShape.Points.Add(p1);

                    p.Shapes.Add(newShape);

                    dbdc.SubmitChanges();

                    LoadImage();
                }
            }
        }
        Shape newShape;
        private void pictureBoxPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (listBoxPages.SelectedItem is Page)
                {
                    if (newShape is Shape)
                    {
                        Point p1 = new Point();
                        p1.X = e.X;
                        p1.Y = e.Y;

                        newShape.Points.Add(p1);

                        dbdc.SubmitChanges();

                        LoadImage();
                    }
                }
            }
        }
        private void pictureBoxPage_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pictureBoxPage_MouseMove(sender, e);
            }
        }
        private void LoadImage()
        {
            if (listBoxPages.SelectedItem is Page)
            {
                Page p = listBoxPages.SelectedItem as Page;

                pictureBoxPage.Image = new Bitmap(pictureBoxPage.Width, pictureBoxPage.Height);
                Graphics g = Graphics.FromImage(pictureBoxPage.Image);

                g.Clear(Color.White);
                foreach (Shape s in p.Shapes)
                {
                    Pen pen = new Pen(Color.FromArgb(s.Color), s.Width);
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                    for (int i = 0; i < s.Points.Count - 1; i++)
                    {
                        g.DrawLine(pen,
                            s.Points[i].X,
                            s.Points[i].Y,
                            s.Points[i + 1].X,
                            s.Points[i + 1].Y);
                    }
                }
                pictureBoxPage.Refresh();
            }
        }

        private void buttonPenColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                buttonPenColor.BackColor = cd.Color;
            }
        }
    }
}
