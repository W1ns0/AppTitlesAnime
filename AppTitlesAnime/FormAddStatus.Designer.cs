namespace AppTitlesAnime
{
    partial class FormAddStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelFill = new Panel();
            textBoxStatusName = new TextBox();
            labelStatusName = new Label();
            flowLayoutPanelBottom = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            errorProvider = new ErrorProvider(components);
            panelFill.SuspendLayout();
            flowLayoutPanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(textBoxStatusName);
            panelFill.Controls.Add(labelStatusName);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Font = new Font("Segoe UI", 14.25F);
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10, 10, 20, 10);
            panelFill.Size = new Size(432, 97);
            panelFill.TabIndex = 0;
            // 
            // textBoxStatusName
            // 
            textBoxStatusName.Dock = DockStyle.Top;
            textBoxStatusName.Location = new Point(10, 35);
            textBoxStatusName.Name = "textBoxStatusName";
            textBoxStatusName.Size = new Size(402, 33);
            textBoxStatusName.TabIndex = 1;
            textBoxStatusName.TextChanged += TextBoxStatusName_TextChanged;
            textBoxStatusName.Validating += TextBoxStatusName_Validating;
            // 
            // labelStatusName
            // 
            labelStatusName.AutoSize = true;
            labelStatusName.Dock = DockStyle.Top;
            labelStatusName.Location = new Point(10, 10);
            labelStatusName.Name = "labelStatusName";
            labelStatusName.Size = new Size(128, 25);
            labelStatusName.TabIndex = 0;
            labelStatusName.Text = "Статус аниме";
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.AutoSize = true;
            flowLayoutPanelBottom.BackColor = Color.White;
            flowLayoutPanelBottom.Controls.Add(btnSaveChanges);
            flowLayoutPanelBottom.Controls.Add(btnCancel);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.Font = new Font("Segoe UI", 14.25F);
            flowLayoutPanelBottom.Location = new Point(0, 97);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10, 10, 20, 10);
            flowLayoutPanelBottom.Size = new Size(432, 61);
            flowLayoutPanelBottom.TabIndex = 1;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.AutoSize = true;
            btnSaveChanges.DialogResult = DialogResult.OK;
            btnSaveChanges.Location = new Point(13, 13);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(115, 35);
            btnSaveChanges.TabIndex = 0;
            btnSaveChanges.Text = "Сохранить";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(134, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormAddStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(432, 158);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelBottom);
            Name = "FormAddStatus";
            Text = "Информация о статусе аниме";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            flowLayoutPanelBottom.ResumeLayout(false);
            flowLayoutPanelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFill;
        private Label labelStatusName;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button btnSaveChanges;
        private Button btnCancel;
        protected internal TextBox textBoxStatusName;
        private ErrorProvider errorProvider;
    }
}