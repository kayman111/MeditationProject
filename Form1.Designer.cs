using System.Windows.Forms;

namespace Meditation
{
    partial class Form1
    {
        private System.Windows.Forms.Label labelStressTitle;
        private System.Windows.Forms.ListBox listBoxStressSigns;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Button buttonSea;
        private System.Windows.Forms.Button buttonNature;
        private System.Windows.Forms.Button buttonField;
        private System.Windows.Forms.Button buttonASMR;
        private Label inhaleExhaleLabel;

        private void InitializeComponent()
        {
            this.labelStressTitle = new System.Windows.Forms.Label();
            this.listBoxStressSigns = new System.Windows.Forms.ListBox();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonSea = new System.Windows.Forms.Button();
            this.buttonNature = new System.Windows.Forms.Button();
            this.buttonField = new System.Windows.Forms.Button();
            this.buttonASMR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            
            this.inhaleExhaleLabel = new System.Windows.Forms.Label();
            
            this.inhaleExhaleLabel.Text = "Вдохните...";
            this.inhaleExhaleLabel.Font = new System.Drawing.Font("Arial", 20);
            this.inhaleExhaleLabel.Location = new System.Drawing.Point(250, 150);
            this.inhaleExhaleLabel.Size = new System.Drawing.Size(300, 40);
            this.Controls.Add(this.inhaleExhaleLabel);
            
            this.labelStressTitle.Text = "Выберите признак стресса:";
            this.labelStressTitle.Location = new System.Drawing.Point(20, 80);
            this.labelStressTitle.Size = new System.Drawing.Size(200, 20);

            
            this.listBoxStressSigns.Items.AddRange(new object[] {
    "Бессонница",
    "Мышечное напряжение",
    "Повышенная тревожность",
    "Рассеянность"});
            this.listBoxStressSigns.Location = new System.Drawing.Point(20, 100);
            this.listBoxStressSigns.Size = new System.Drawing.Size(200, 100);
            this.listBoxStressSigns.SelectedIndexChanged += new System.EventHandler(this.listBoxStressSigns_SelectedIndexChanged);

            
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(250, 400);
            this.mediaPlayer.Size = new System.Drawing.Size(300, 45);
            this.mediaPlayer.CreateControl();

            
            this.buttonSea.Text = "Звук моря";
            this.buttonSea.Location = new System.Drawing.Point(600, 50);
            this.buttonSea.Size = new System.Drawing.Size(150, 40);
            this.buttonSea.Click += new System.EventHandler(this.buttonSea_Click);

            
            this.buttonNature.Text = "Звук природы";
            this.buttonNature.Location = new System.Drawing.Point(600, 100);
            this.buttonNature.Size = new System.Drawing.Size(150, 40);
            this.buttonNature.Click += new System.EventHandler(this.buttonNature_Click);

            
            this.buttonField.Text = "Атмосферный звук поля";
            this.buttonField.Location = new System.Drawing.Point(600, 150);
            this.buttonField.Size = new System.Drawing.Size(150, 40);
            this.buttonField.Click += new System.EventHandler(this.buttonField_Click);

           
            this.buttonASMR.Text = "АСМР";
            this.buttonASMR.Location = new System.Drawing.Point(600, 200);
            this.buttonASMR.Size = new System.Drawing.Size(150, 40);
            this.buttonASMR.Click += new System.EventHandler(this.buttonASMR_Click);

            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.labelStressTitle);
            this.Controls.Add(this.listBoxStressSigns);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.buttonSea);
            this.Controls.Add(this.buttonNature);
            this.Controls.Add(this.buttonField);
            this.Controls.Add(this.buttonASMR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\User\Downloads\Telegram Desktop\IMG_3829.JPG");
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Name = "Form1";
            this.Text = "Meditation";
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);
        }

    }
}