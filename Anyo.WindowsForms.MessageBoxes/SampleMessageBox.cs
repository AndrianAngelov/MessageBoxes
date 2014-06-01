namespace Anyo.WindowsForms.MessageBoxes
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    ///  Displays a message box that can contain text that inform
    ///  and instruct the user.
    /// </summary>
    /// <example>
    /// <img src="../Images/SampleMessageBox.jpg" />
    /// <code>
    /// using Anyo.WindowsForms.MessageBoxes;
    /// 
    /// private void show_btn_Click(object sender, EventArgs e)
    /// {
    ///     object nullObject = null;
    ///     try
    ///     {
    ///         int someIntVariable = (int)nullObject;
    ///     }
    ///     catch (Exception ex)
    ///     {
    ///         SampleMessageBox.Show(ex.Message);
    ///     }
    /// }
    /// </code> 
    /// </example>
    public partial class SampleMessageBox : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public SampleMessageBox()
        {
            InitializeComponent();

            this.message_richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }
        /// <summary>
        /// Displays a message box with specified text.
        /// </summary>
        /// <param name="messageText">The text to display in the message box.</param>
        private SampleMessageBox(string messageText)
            : this()
        {
            this.message_richTextBox.Text = messageText;

            ResizeSampleMessageBox();
        }

        /// <summary>
        /// Displays a message box with specified text and caption.
        /// </summary>
        /// <param name="messageText">The text to display in the message box.</param>
        /// <param name="captionText">The text to display in the title bar of the message box.</param>
        private SampleMessageBox(string messageText, string captionText)
            : this(messageText)
        {
            this.Text = captionText;

        }

        /// <summary>
        /// Displays a message box with specified text.
        /// </summary>
        /// <param name="messageText">The text to display in the message box.</param>
        public static void Show(string messageText)
        {
            SampleMessageBox instance = new SampleMessageBox(messageText);
            instance.ShowDialog();
        }

        /// <summary>
        ///  Displays a message box with specified text and caption.
        /// </summary>
        /// <param name="messageText">The text to display in the message box.</param>
        /// <param name="captionText">The text to display in the title bar of the message box.</param>
        public static void Show(string messageText, string captionText)
        {
            SampleMessageBox instance = new SampleMessageBox(messageText, captionText);
            instance.ShowDialog();
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResizeSampleMessageBox()
        {
            if (message_richTextBox.TextLength > 65)
            {
                for (int i = 0; i < message_richTextBox.TextLength / 65; i++)
                {
                    this.message_richTextBox.Size = new Size(this.message_richTextBox.Size.Width, this.message_richTextBox.Size.Height + 20);
                }
                this.Size = new Size(this.Size.Width, this.Size.Height + this.message_richTextBox.Size.Height - 25);
            }
        }
    }
}
