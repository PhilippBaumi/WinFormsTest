using System.Collections.ObjectModel;

namespace WinFormsTest
{
    public partial class WinFormsTest : Form
    {
        private ObservableCollection<string>dates=new();
        public WinFormsTest()
        {
            InitializeComponent();
        }

        private void datesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection dates = datesList.SelectedItems;
            if (dates.Count == 1)
            {
                ListViewItem item= dates[0];
                MessageBox.Show("Du hast den "+item.Text+" gewählt! ","Datum gewählt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string s=datePickerDate.Value.ToString("dd.MM.yyyy").Trim();
            if(!dates.Contains(s)) 
            {
                dates.Add(s);
                datesList.Items.Clear();
                foreach (string d in dates)
                {
                    datesList.Items.Add(d);
                }
            }
            else
            {
                MessageBox.Show("Datum " + s + " bereits vorhanden","Datum vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
