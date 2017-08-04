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

namespace OnThiTracNghiem
{
    public partial class FormTaoMonHoc : Form
    {
        public FormTaoMonHoc()
        {
            InitializeComponent();
        }

        private void btnFolderQuestions_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //fbd.Description = "Chặt đôi câu thơ tôi làm mái chèo lướt sóng!";
            fbd.Description = "Select a folder which has your images";
            if (fbd.ShowDialog() == DialogResult.OK)
                tbxFolderQuestions.Text = fbd.SelectedPath;
        }

        private bool CheckInit()
        {
            if (tbxFolderQuestions.Text == "" || tbxSubjectFolderName.Text == "" || tbxSubjectName.Text == "")
                return false;
            else return true;
        }

        private bool CreateNewSubject()
        {
            //MessageBox.Show("CreateNewSubject");

            //Create new folder
            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(Contents.sourcesPath + tbxSubjectFolderName.Text))
                {
                    Console.WriteLine("That path exists already.");
                    return false;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(Contents.sourcesPath + tbxSubjectFolderName.Text);
                // Try to create the question folder.
                DirectoryInfo di1 = Directory.CreateDirectory(Contents.sourcesPath + tbxSubjectFolderName.Text + @"/question");
            }
            catch (Exception e)
            {
                MessageBox.Show("The process failed: " + e.ToString());
            }

            //Copy all files to new folder:
            foreach (var sourceFilePath in Directory.GetFiles(tbxFolderQuestions.Text))
            {
                string fileName = Path.GetFileName(sourceFilePath);
                string destinationFilePath = Path.Combine(Contents.sourcesPath + tbxSubjectFolderName.Text + @"/question", fileName);

                System.IO.File.Copy(sourceFilePath, destinationFilePath, true);
            }

            //Save file sub.ini
            SubjectsManager subsManager = new SubjectsManager();
            subsManager.LoadFile();
            subsManager.AddNewSubject(tbxSubjectName.Text, tbxSubjectFolderName.Text);
            subsManager.SaveFile();

            //Create default data files
            Contents.TaoMacDinhDuLieuSources(tbxSubjectFolderName.Text);

            return true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (CheckInit() == false)
                MessageBox.Show("You must fill the form before create new one.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
            {
                if (CreateNewSubject())
                    MessageBox.Show("Hãy nhớ đặt lại các thiết lập" + Environment.NewLine + "và nhập lại toàn bộ đáp án!" + Environment.NewLine + "cho môn học mới này!", "Cho anh xin những ân cần!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else MessageBox.Show("This subject may be exists already.");
                this.Close();
            }

        }
    }
}
