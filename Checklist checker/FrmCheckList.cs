using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checklist_checker
{
    public partial class FrmCheckList : Form
    {
        private string listName;
        private List<CheckListItem> checkListItems = new List<CheckListItem>();
        public FrmCheckList(string listName)
        {
            InitializeComponent();
            this.listName = listName;
            lblHeader.Text = listName;
            GetCsvData();
            PopulateChecklist();
            lblHeader.Left = (Width) / 2;
        }

        private void PopulateChecklist()
        {
            if (checkListItems != null)
            {
                string position;
                position = checkListItems[0].Position;
                Label labelPos1 = new Label();
                labelPos1.Text = position;
                labelPos1.Font = new Font(labelPos1.Font.FontFamily, 12);
                flowLayoutPanelChecklist.Controls.Add(labelPos1);

                foreach (var item in checkListItems)
                {
                    if (item.Position != position)
                    {
                        Label label = new Label();
                        position = item.Position;
                        label.Text = position;
                        label.Font = new Font(labelPos1.Font.FontFamily, 12);
                        flowLayoutPanelChecklist.Controls.Add(label);
                    }
                    CheckBox checkBox = new CheckBox();
                    checkBox.Text = item.Text;
                    checkBox.Checked = item.IsChecked;
                    checkBox.AutoSize = true;

                    // Add event handler for check state changed
                    checkBox.CheckedChanged += (sender, e) =>
                    {
                        // Update checklist item state
                        item.IsChecked = checkBox.Checked;
                    };

                    flowLayoutPanelChecklist.Controls.Add(checkBox);
                }
            }
        }

        private void GetCsvData()
        {
            string path;

            path = listName + ".csv";

            if (!File.Exists(path))
            {
                MessageBox.Show("File does not exist.");
            }
            else
            {
                string[] lines = File.ReadAllLines(path);

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(';');
                    CheckListItem item = new CheckListItem(values[0], values[1]);
                    checkListItems.Add(item);
                }
            }
        }

        private void SendToDatabase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["IIT"].ConnectionString;

        }
    }
}
