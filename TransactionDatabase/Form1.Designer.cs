namespace TransactionDatabase
{
    partial class Form1
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
            this.openXmlFileButton = new System.Windows.Forms.Button();
            this.openXslFileButton = new System.Windows.Forms.Button();
            this.searchQuestionButton = new System.Windows.Forms.Button();
            this.xmlOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.xslOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.testsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.byIdRadioButton = new System.Windows.Forms.RadioButton();
            this.ByDateRadioButton = new System.Windows.Forms.RadioButton();
            this.ByCategoryRadioButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LinqRadioButton = new System.Windows.Forms.RadioButton();
            this.DomRadioButton = new System.Windows.Forms.RadioButton();
            this.SaxRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openXmlFileButton
            // 
            this.openXmlFileButton.Location = new System.Drawing.Point(103, 12);
            this.openXmlFileButton.Name = "openXmlFileButton";
            this.openXmlFileButton.Size = new System.Drawing.Size(75, 23);
            this.openXmlFileButton.TabIndex = 5;
            this.openXmlFileButton.Text = "Open";
            this.openXmlFileButton.UseVisualStyleBackColor = true;
            this.openXmlFileButton.Click += new System.EventHandler(this.openXmlFileButton_Click);
            // 
            // openXslFileButton
            // 
            this.openXslFileButton.Location = new System.Drawing.Point(194, 12);
            this.openXslFileButton.Name = "openXslFileButton";
            this.openXslFileButton.Size = new System.Drawing.Size(109, 23);
            this.openXslFileButton.TabIndex = 7;
            this.openXslFileButton.Text = "Save to HTML";
            this.openXslFileButton.UseVisualStyleBackColor = true;
            this.openXslFileButton.Click += new System.EventHandler(this.transformationButton_Click);
            // 
            // searchQuestionButton
            // 
            this.searchQuestionButton.Location = new System.Drawing.Point(15, 469);
            this.searchQuestionButton.Name = "searchQuestionButton";
            this.searchQuestionButton.Size = new System.Drawing.Size(187, 23);
            this.searchQuestionButton.TabIndex = 12;
            this.searchQuestionButton.Text = "Пошук";
            this.searchQuestionButton.UseVisualStyleBackColor = true;
            this.searchQuestionButton.Click += new System.EventHandler(this.searchQuestionButton_Click);
            // 
            // xmlOpenFileDialog
            // 
            this.xmlOpenFileDialog.FileName = "xmlOpenFileDialog";
            this.xmlOpenFileDialog.Filter = "\"XML-файли (*.xml)|*.xml|Всі файли (*.*)|*.*\"";
            // 
            // xslOpenFileDialog
            // 
            this.xslOpenFileDialog.FileName = "xslOpenFileDialog";
            this.xslOpenFileDialog.Filter = "\"XSL-файли (*.xsl)|*.xsl|Всі файли (*.*)|*.*\"";
            // 
            // testsListView
            // 
            this.testsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4});
            this.testsListView.Location = new System.Drawing.Point(12, 41);
            this.testsListView.Name = "testsListView";
            this.testsListView.Size = new System.Drawing.Size(619, 381);
            this.testsListView.TabIndex = 13;
            this.testsListView.UseCompatibleStateImageBehavior = false;
            this.testsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "№";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Тип";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Розмір";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Категорія";
            this.columnHeader5.Width = 101;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Дата";
            this.columnHeader4.Width = 104;
            // 
            // byIdRadioButton
            // 
            this.byIdRadioButton.AutoSize = true;
            this.byIdRadioButton.Location = new System.Drawing.Point(8, 439);
            this.byIdRadioButton.Name = "byIdRadioButton";
            this.byIdRadioButton.Size = new System.Drawing.Size(87, 17);
            this.byIdRadioButton.TabIndex = 14;
            this.byIdRadioButton.TabStop = true;
            this.byIdRadioButton.Text = "Пошук за №";
            this.byIdRadioButton.UseVisualStyleBackColor = true;
            // 
            // ByDateRadioButton
            // 
            this.ByDateRadioButton.AutoSize = true;
            this.ByDateRadioButton.Location = new System.Drawing.Point(134, 439);
            this.ByDateRadioButton.Name = "ByDateRadioButton";
            this.ByDateRadioButton.Size = new System.Drawing.Size(107, 17);
            this.ByDateRadioButton.TabIndex = 15;
            this.ByDateRadioButton.TabStop = true;
            this.ByDateRadioButton.Text = "Пошук за датою";
            this.ByDateRadioButton.UseVisualStyleBackColor = true;
            // 
            // ByCategoryRadioButton
            // 
            this.ByCategoryRadioButton.AutoSize = true;
            this.ByCategoryRadioButton.Location = new System.Drawing.Point(389, 441);
            this.ByCategoryRadioButton.Name = "ByCategoryRadioButton";
            this.ByCategoryRadioButton.Size = new System.Drawing.Size(132, 17);
            this.ByCategoryRadioButton.TabIndex = 16;
            this.ByCategoryRadioButton.TabStop = true;
            this.ByCategoryRadioButton.Text = "Пошук за категорією";
            this.ByCategoryRadioButton.UseVisualStyleBackColor = true;
            this.ByCategoryRadioButton.CheckedChanged += new System.EventHandler(this.ByCategoryRadioButton_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 438);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 20);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(237, 439);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 20);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(520, 440);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(316, 439);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(68, 20);
            this.textBox4.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaxRadioButton);
            this.groupBox1.Controls.Add(this.DomRadioButton);
            this.groupBox1.Controls.Add(this.LinqRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(350, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 34);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // LinqRadioButton
            // 
            this.LinqRadioButton.AutoSize = true;
            this.LinqRadioButton.Location = new System.Drawing.Point(3, 12);
            this.LinqRadioButton.Name = "LinqRadioButton";
            this.LinqRadioButton.Size = new System.Drawing.Size(50, 17);
            this.LinqRadioButton.TabIndex = 0;
            this.LinqRadioButton.TabStop = true;
            this.LinqRadioButton.Text = "LINQ";
            this.LinqRadioButton.UseVisualStyleBackColor = true;
            this.LinqRadioButton.CheckedChanged += new System.EventHandler(this.LinqRadioButton_CheckedChanged);
            // 
            // DomRadioButton
            // 
            this.DomRadioButton.AutoSize = true;
            this.DomRadioButton.Location = new System.Drawing.Point(74, 11);
            this.DomRadioButton.Name = "DomRadioButton";
            this.DomRadioButton.Size = new System.Drawing.Size(50, 17);
            this.DomRadioButton.TabIndex = 1;
            this.DomRadioButton.TabStop = true;
            this.DomRadioButton.Text = "DOM";
            this.DomRadioButton.UseVisualStyleBackColor = true;
            this.DomRadioButton.CheckedChanged += new System.EventHandler(this.DomRadioButton_CheckedChanged);
            // 
            // SaxRadioButton
            // 
            this.SaxRadioButton.AutoSize = true;
            this.SaxRadioButton.Location = new System.Drawing.Point(148, 11);
            this.SaxRadioButton.Name = "SaxRadioButton";
            this.SaxRadioButton.Size = new System.Drawing.Size(46, 17);
            this.SaxRadioButton.TabIndex = 2;
            this.SaxRadioButton.TabStop = true;
            this.SaxRadioButton.Text = "SAX";
            this.SaxRadioButton.UseVisualStyleBackColor = true;
            this.SaxRadioButton.CheckedChanged += new System.EventHandler(this.SaxRadioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 504);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ByCategoryRadioButton);
            this.Controls.Add(this.ByDateRadioButton);
            this.Controls.Add(this.byIdRadioButton);
            this.Controls.Add(this.testsListView);
            this.Controls.Add(this.searchQuestionButton);
            this.Controls.Add(this.openXslFileButton);
            this.Controls.Add(this.openXmlFileButton);
            this.Name = "Form1";
            this.Text = "MoneyDatabase";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openXmlFileButton;
        private System.Windows.Forms.Button openXslFileButton;
        private System.Windows.Forms.Button searchQuestionButton;
        private System.Windows.Forms.OpenFileDialog xmlOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog xslOpenFileDialog;
        private System.Windows.Forms.ListView testsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.RadioButton byIdRadioButton;
        private System.Windows.Forms.RadioButton ByDateRadioButton;
        private System.Windows.Forms.RadioButton ByCategoryRadioButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SaxRadioButton;
        private System.Windows.Forms.RadioButton DomRadioButton;
        private System.Windows.Forms.RadioButton LinqRadioButton;
    }
}

