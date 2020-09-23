using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserMaintanence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName,false,Encoding.UTF8))
            {

                foreach (var s in users)
                {
                    sw.Write(s.LastName);
                    sw.Write(s.FirstName);
                    sw.Write(s.FullName);
                    sw.WriteLine();
                    
                }
            }
            
        }
    }
}
