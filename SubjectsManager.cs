using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnThiTracNghiem
{
    public class SubjectsManager
    {
        List<Subject> _subjects;
        int _subSelected;

        public List<Subject> Subjects
        {
            get
            {
                return _subjects;
            }

            set
            {
                _subjects = value;
            }
        }

        public int SubSelected
        {
            get
            {
                return _subSelected;
            }

            set
            {
                _subSelected = value;
            }
        }

        public void LoadFile()
        {
            List<string> lines = File.ReadAllLines(Contents.SourcesPath + Contents.fileNameSubjects).ToList();
            _subjects = new List<Subject>();
            for (int i = 0; i < lines.Count() - 1; i += 2)
                _subjects.Add(new Subject(lines[i], lines[i + 1]));
            _subSelected = int.Parse(lines[lines.Count - 1]);
        }

        public void SaveFile()
        {
            StreamWriter file = new StreamWriter(Contents.SourcesPath + Contents.fileNameSubjects);
            for (int i = 0; i < _subjects.Count; i++)
            {
                file.WriteLine(_subjects[i].Name);
                file.WriteLine(_subjects[i].FolderName);
            }
            file.WriteLine(_subSelected);
            file.Close();
            file.Dispose();
        }

        public void AddBindingDataSubjectsName(ComboBox cbx)
        {
            //cbx.DataBindings.Add(new Binding("DataSource", _subjects, "Name"));

            cbx.DisplayMember = "Name";
            for (int i = 0; i < _subjects.Count; i++)
                cbx.Items.Add(_subjects[i]);
            cbx.SelectedIndex = _subSelected;
        }
    }

    public class Subject
    {
        string _name;
        string _folderName;

        public Subject(string _name, string _folderName)
        {
            this._name = _name;
            this._folderName = _folderName;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string FolderName
        {
            get
            {
                return _folderName;
            }

            set
            {
                _folderName = value;
            }
        }

    }
}
