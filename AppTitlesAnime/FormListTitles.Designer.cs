﻿namespace AppTitlesAnime
{
    partial class FormListTitles
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
            flowLayoutPanelTop = new FlowLayoutPanel();
            btnAddTitle = new Button();
            btnUpdateTitle = new Button();
            btnDeleteTitle = new Button();
            panelFill = new Panel();
            dataGridViewTitles = new DataGridView();
            flowLayoutPanelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTitles).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.BackColor = Color.White;
            flowLayoutPanelTop.Controls.Add(btnAddTitle);
            flowLayoutPanelTop.Controls.Add(btnUpdateTitle);
            flowLayoutPanelTop.Controls.Add(btnDeleteTitle);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(934, 61);
            flowLayoutPanelTop.TabIndex = 1;
            // 
            // btnAddTitle
            // 
            btnAddTitle.AutoSize = true;
            btnAddTitle.Location = new Point(13, 13);
            btnAddTitle.Name = "btnAddTitle";
            btnAddTitle.Size = new Size(106, 35);
            btnAddTitle.TabIndex = 0;
            btnAddTitle.Text = "Добавить";
            btnAddTitle.UseVisualStyleBackColor = true;
            btnAddTitle.Click += BtnAddTitle_Click;
            // 
            // btnUpdateTitle
            // 
            btnUpdateTitle.AutoSize = true;
            btnUpdateTitle.Location = new Point(125, 13);
            btnUpdateTitle.Name = "btnUpdateTitle";
            btnUpdateTitle.Size = new Size(151, 35);
            btnUpdateTitle.TabIndex = 1;
            btnUpdateTitle.Text = "Редактировать";
            btnUpdateTitle.UseVisualStyleBackColor = true;
            btnUpdateTitle.Click += BtnUpdateTitle_Click;
            // 
            // btnDeleteTitle
            // 
            btnDeleteTitle.AutoSize = true;
            btnDeleteTitle.Location = new Point(282, 13);
            btnDeleteTitle.Name = "btnDeleteTitle";
            btnDeleteTitle.Size = new Size(92, 35);
            btnDeleteTitle.TabIndex = 2;
            btnDeleteTitle.Text = "Удалить";
            btnDeleteTitle.UseVisualStyleBackColor = true;
            btnDeleteTitle.Click += BtnDeleteTitle_Click;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewTitles);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 61);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(934, 450);
            panelFill.TabIndex = 3;
            // 
            // dataGridViewTitles
            // 
            dataGridViewTitles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTitles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTitles.BackgroundColor = Color.White;
            dataGridViewTitles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTitles.Dock = DockStyle.Fill;
            dataGridViewTitles.Location = new Point(10, 10);
            dataGridViewTitles.MultiSelect = false;
            dataGridViewTitles.Name = "dataGridViewTitles";
            dataGridViewTitles.ReadOnly = true;
            dataGridViewTitles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTitles.Size = new Size(914, 430);
            dataGridViewTitles.TabIndex = 1;
            // 
            // FormListTitles
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 511);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormListTitles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Тайтлы аниме";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTitles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button btnAddTitle;
        private Button btnUpdateTitle;
        private Button btnDeleteTitle;
        private Panel panelFill;
        private DataGridView dataGridViewTitles;
    }
}