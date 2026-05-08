namespace FileCountReporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Define columns for DataGrid
            dataGridView1.Columns.Add("Extension", "File Type");
            dataGridView1.Columns.Add("Count", "Count");
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                // When the user clicks ok after selecting a directory
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // Show the selected directory in the textbox
                    folderPathTextBox.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            // Clear the table from any previous search results
            dataGridView1.Rows.Clear();

            // Get the user selected directory from the textbox
            string userSelectedPath = folderPathTextBox.Text;

            // Check if folder is empty or exists
            if (string.IsNullOrEmpty(userSelectedPath) || !Directory.Exists(userSelectedPath)) 
            {
                MessageBox.Show("Please select a valid folder");
            }

            // Get all files within folder
            string[] files = Directory.GetFiles(userSelectedPath);

            // AI suggestion to create a dictionary to store file extensions/ counts
            Dictionary<string, int> fileCounts = new Dictionary<string, int>();

            // Loop to run every file
            foreach (string file in files)
            {
                // Get the extension
                string extension = Path.GetExtension(file).ToLower();

                // If there is no extension
                if (extension == "")
                {
                    extension = "[No Extension]";
                }

                // If extension already exists in dictionary
                if (fileCounts.ContainsKey(extension))
                {
                    // Increment count by 1
                    fileCounts[extension]++;
                } else
                {
                    // First of its kind
                    fileCounts.Add(extension, 1);
                }
            }
            // Add results to the DataGrid table
            foreach (KeyValuePair<string, int> item in fileCounts)
            {
                dataGridView1.Rows.Add(item.Key, item.Value);
            }
        }
    }
}
