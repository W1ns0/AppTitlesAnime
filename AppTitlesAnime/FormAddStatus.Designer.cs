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
            panelFill = new Panel();
            textBoxStatusName = new TextBox();
            labelStatusName = new Label();
            flowLayoutPanelBottom = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            panelFill.SuspendLayout();
            flowLayoutPanelBottom.SuspendLayout();
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
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(399, 109);
            panelFill.TabIndex = 4;
            // 
            // textBoxStatusName
            // 
            textBoxStatusName.Dock = DockStyle.Top;
            textBoxStatusName.Location = new Point(10, 35);
            textBoxStatusName.Name = "textBoxStatusName";
            textBoxStatusName.Size = new Size(379, 33);
            textBoxStatusName.TabIndex = 1;
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
            flowLayoutPanelBottom.Location = new Point(0, 109);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10);
            flowLayoutPanelBottom.Size = new Size(399, 61);
            flowLayoutPanelBottom.TabIndex = 3;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.AutoSize = true;
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
            btnCancel.Location = new Point(134, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormAddStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(399, 170);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelBottom);
            Name = "FormAddStatus";
            Text = "FormAddStatus";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            flowLayoutPanelBottom.ResumeLayout(false);
            flowLayoutPanelBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFill;
        private TextBox textBoxStatusName;
        private Label labelStatusName;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button btnSaveChanges;
        private Button btnCancel;
    }
}