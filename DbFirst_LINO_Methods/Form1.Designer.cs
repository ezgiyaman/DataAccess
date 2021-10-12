
namespace DbFirst_LINO_Methods
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnToList = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnOrderBy = new System.Windows.Forms.Button();
            this.btnStartsWith = new System.Windows.Forms.Button();
            this.btnEndsWith = new System.Windows.Forms.Button();
            this.btnAny = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.btnDistinct = new System.Windows.Forms.Button();
            this.btnGroupBy = new System.Windows.Forms.Button();
            this.BtnOrderByDescending = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnFirstOfDefault = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(964, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1044, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 148);
            this.listBox1.TabIndex = 1;
            // 
            // btnToList
            // 
            this.btnToList.Location = new System.Drawing.Point(36, 201);
            this.btnToList.Name = "btnToList";
            this.btnToList.Size = new System.Drawing.Size(115, 42);
            this.btnToList.TabIndex = 2;
            this.btnToList.Text = "To List";
            this.btnToList.UseVisualStyleBackColor = true;
            this.btnToList.Click += new System.EventHandler(this.btnToList_Click);
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(36, 261);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(115, 42);
            this.btnTake.TabIndex = 2;
            this.btnTake.Text = "Take";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(170, 201);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(115, 42);
            this.btnWhere.TabIndex = 2;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(170, 261);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(115, 42);
            this.btnSkip.TabIndex = 2;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(312, 201);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(115, 42);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(312, 261);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(115, 42);
            this.btnContains.TabIndex = 2;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnOrderBy
            // 
            this.btnOrderBy.Location = new System.Drawing.Point(451, 201);
            this.btnOrderBy.Name = "btnOrderBy";
            this.btnOrderBy.Size = new System.Drawing.Size(115, 42);
            this.btnOrderBy.TabIndex = 2;
            this.btnOrderBy.Text = "Order By";
            this.btnOrderBy.UseVisualStyleBackColor = true;
            this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
            // 
            // btnStartsWith
            // 
            this.btnStartsWith.Location = new System.Drawing.Point(451, 261);
            this.btnStartsWith.Name = "btnStartsWith";
            this.btnStartsWith.Size = new System.Drawing.Size(115, 42);
            this.btnStartsWith.TabIndex = 2;
            this.btnStartsWith.Text = "Starts With";
            this.btnStartsWith.UseVisualStyleBackColor = true;
            this.btnStartsWith.Click += new System.EventHandler(this.btnStartsWith_Click);
            // 
            // btnEndsWith
            // 
            this.btnEndsWith.Location = new System.Drawing.Point(588, 261);
            this.btnEndsWith.Name = "btnEndsWith";
            this.btnEndsWith.Size = new System.Drawing.Size(115, 42);
            this.btnEndsWith.TabIndex = 2;
            this.btnEndsWith.Text = "Ends With";
            this.btnEndsWith.UseVisualStyleBackColor = true;
            this.btnEndsWith.Click += new System.EventHandler(this.btnEndsWith_Click);
            // 
            // btnAny
            // 
            this.btnAny.Location = new System.Drawing.Point(728, 261);
            this.btnAny.Name = "btnAny";
            this.btnAny.Size = new System.Drawing.Size(115, 42);
            this.btnAny.TabIndex = 2;
            this.btnAny.Text = "Any";
            this.btnAny.UseVisualStyleBackColor = true;
            this.btnAny.Click += new System.EventHandler(this.btnAny_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(869, 261);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(115, 42);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(1011, 261);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(115, 42);
            this.btnSum.TabIndex = 2;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMinMax
            // 
            this.btnMinMax.Location = new System.Drawing.Point(1143, 261);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(115, 42);
            this.btnMinMax.TabIndex = 2;
            this.btnMinMax.Text = "Min/Max";
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // btnDistinct
            // 
            this.btnDistinct.Location = new System.Drawing.Point(36, 324);
            this.btnDistinct.Name = "btnDistinct";
            this.btnDistinct.Size = new System.Drawing.Size(115, 42);
            this.btnDistinct.TabIndex = 2;
            this.btnDistinct.Text = "Distinct";
            this.btnDistinct.UseVisualStyleBackColor = true;
            this.btnDistinct.Click += new System.EventHandler(this.btnDistinct_Click);
            // 
            // btnGroupBy
            // 
            this.btnGroupBy.Location = new System.Drawing.Point(170, 324);
            this.btnGroupBy.Name = "btnGroupBy";
            this.btnGroupBy.Size = new System.Drawing.Size(115, 42);
            this.btnGroupBy.TabIndex = 2;
            this.btnGroupBy.Text = "Group By";
            this.btnGroupBy.UseVisualStyleBackColor = true;
            this.btnGroupBy.Click += new System.EventHandler(this.btnGroupBy_Click);
            // 
            // BtnOrderByDescending
            // 
            this.BtnOrderByDescending.Location = new System.Drawing.Point(588, 201);
            this.BtnOrderByDescending.Name = "BtnOrderByDescending";
            this.BtnOrderByDescending.Size = new System.Drawing.Size(255, 42);
            this.BtnOrderByDescending.TabIndex = 2;
            this.BtnOrderByDescending.Text = "Order By Descending";
            this.BtnOrderByDescending.UseVisualStyleBackColor = true;
            this.BtnOrderByDescending.Click += new System.EventHandler(this.BtnOrderByDescending_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(869, 201);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(113, 42);
            this.btnFirst.TabIndex = 2;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnFirstOfDefault
            // 
            this.btnFirstOfDefault.Location = new System.Drawing.Point(1011, 201);
            this.btnFirstOfDefault.Name = "btnFirstOfDefault";
            this.btnFirstOfDefault.Size = new System.Drawing.Size(113, 42);
            this.btnFirstOfDefault.TabIndex = 2;
            this.btnFirstOfDefault.Text = "First Of Default";
            this.btnFirstOfDefault.UseVisualStyleBackColor = true;
            this.btnFirstOfDefault.Click += new System.EventHandler(this.btnFirstOfDefault_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(1143, 201);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(113, 42);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(312, 324);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(115, 42);
            this.btnJoin.TabIndex = 3;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 450);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnToList);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnOrderBy);
            this.Controls.Add(this.btnStartsWith);
            this.Controls.Add(this.btnEndsWith);
            this.Controls.Add(this.btnAny);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnMinMax);
            this.Controls.Add(this.btnDistinct);
            this.Controls.Add(this.btnGroupBy);
            this.Controls.Add(this.BtnOrderByDescending);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnFirstOfDefault);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnToList;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnOrderBy;
        private System.Windows.Forms.Button btnStartsWith;
        private System.Windows.Forms.Button btnEndsWith;
        private System.Windows.Forms.Button btnAny;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMinMax;
        private System.Windows.Forms.Button btnDistinct;
        private System.Windows.Forms.Button btnGroupBy;
        private System.Windows.Forms.Button BtnOrderByDescending;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnFirstOfDefault;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnJoin;
    }
}

