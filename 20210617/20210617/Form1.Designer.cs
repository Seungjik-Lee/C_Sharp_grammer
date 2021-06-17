
namespace _20210617
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_write = new System.Windows.Forms.Button();
            this.button_read = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_sabeon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button_jsonAPI = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.drwNo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drwNo2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drwNo3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drwNo4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drwNo5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drwNo6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drwNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drwDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lottoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabeonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_write
            // 
            this.button_write.Location = new System.Drawing.Point(93, 87);
            this.button_write.Name = "button_write";
            this.button_write.Size = new System.Drawing.Size(75, 23);
            this.button_write.TabIndex = 0;
            this.button_write.Text = "추가";
            this.button_write.UseVisualStyleBackColor = true;
            this.button_write.Click += new System.EventHandler(this.button_write_Click);
            // 
            // button_read
            // 
            this.button_read.Location = new System.Drawing.Point(349, 168);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(75, 23);
            this.button_read.TabIndex = 1;
            this.button_read.Text = "읽기";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.sabeonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doctorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(184, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(68, 12);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 21);
            this.textBox_name.TabIndex = 3;
            // 
            // textBox_sabeon
            // 
            this.textBox_sabeon.Location = new System.Drawing.Point(68, 60);
            this.textBox_sabeon.Name = "textBox_sabeon";
            this.textBox_sabeon.Size = new System.Drawing.Size(100, 21);
            this.textBox_sabeon.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "사번";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drwNo1DataGridViewTextBoxColumn,
            this.drwNo2DataGridViewTextBoxColumn,
            this.drwNo3DataGridViewTextBoxColumn,
            this.drwNo4DataGridViewTextBoxColumn,
            this.drwNo5DataGridViewTextBoxColumn,
            this.drwNo6DataGridViewTextBoxColumn,
            this.bonusNoDataGridViewTextBoxColumn,
            this.drwNoDataGridViewTextBoxColumn,
            this.drwDateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.lottoBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 197);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(412, 150);
            this.dataGridView2.TabIndex = 7;
            // 
            // button_jsonAPI
            // 
            this.button_jsonAPI.Location = new System.Drawing.Point(314, 367);
            this.button_jsonAPI.Name = "button_jsonAPI";
            this.button_jsonAPI.Size = new System.Drawing.Size(110, 23);
            this.button_jsonAPI.TabIndex = 8;
            this.button_jsonAPI.Text = "jsonAPI불러오기";
            this.button_jsonAPI.UseVisualStyleBackColor = true;
            this.button_jsonAPI.Click += new System.EventHandler(this.button_jsonAPI_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(430, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(432, 335);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // drwNo1DataGridViewTextBoxColumn
            // 
            this.drwNo1DataGridViewTextBoxColumn.DataPropertyName = "drwNo1";
            this.drwNo1DataGridViewTextBoxColumn.HeaderText = "drwNo1";
            this.drwNo1DataGridViewTextBoxColumn.Name = "drwNo1DataGridViewTextBoxColumn";
            this.drwNo1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drwNo2DataGridViewTextBoxColumn
            // 
            this.drwNo2DataGridViewTextBoxColumn.DataPropertyName = "drwNo2";
            this.drwNo2DataGridViewTextBoxColumn.HeaderText = "drwNo2";
            this.drwNo2DataGridViewTextBoxColumn.Name = "drwNo2DataGridViewTextBoxColumn";
            this.drwNo2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drwNo3DataGridViewTextBoxColumn
            // 
            this.drwNo3DataGridViewTextBoxColumn.DataPropertyName = "drwNo3";
            this.drwNo3DataGridViewTextBoxColumn.HeaderText = "drwNo3";
            this.drwNo3DataGridViewTextBoxColumn.Name = "drwNo3DataGridViewTextBoxColumn";
            this.drwNo3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drwNo4DataGridViewTextBoxColumn
            // 
            this.drwNo4DataGridViewTextBoxColumn.DataPropertyName = "drwNo4";
            this.drwNo4DataGridViewTextBoxColumn.HeaderText = "drwNo4";
            this.drwNo4DataGridViewTextBoxColumn.Name = "drwNo4DataGridViewTextBoxColumn";
            this.drwNo4DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drwNo5DataGridViewTextBoxColumn
            // 
            this.drwNo5DataGridViewTextBoxColumn.DataPropertyName = "drwNo5";
            this.drwNo5DataGridViewTextBoxColumn.HeaderText = "drwNo5";
            this.drwNo5DataGridViewTextBoxColumn.Name = "drwNo5DataGridViewTextBoxColumn";
            this.drwNo5DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drwNo6DataGridViewTextBoxColumn
            // 
            this.drwNo6DataGridViewTextBoxColumn.DataPropertyName = "drwNo6";
            this.drwNo6DataGridViewTextBoxColumn.HeaderText = "drwNo6";
            this.drwNo6DataGridViewTextBoxColumn.Name = "drwNo6DataGridViewTextBoxColumn";
            this.drwNo6DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bonusNoDataGridViewTextBoxColumn
            // 
            this.bonusNoDataGridViewTextBoxColumn.DataPropertyName = "bonusNo";
            this.bonusNoDataGridViewTextBoxColumn.HeaderText = "bonusNo";
            this.bonusNoDataGridViewTextBoxColumn.Name = "bonusNoDataGridViewTextBoxColumn";
            this.bonusNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drwNoDataGridViewTextBoxColumn
            // 
            this.drwNoDataGridViewTextBoxColumn.DataPropertyName = "drwNo";
            this.drwNoDataGridViewTextBoxColumn.HeaderText = "drwNo";
            this.drwNoDataGridViewTextBoxColumn.Name = "drwNoDataGridViewTextBoxColumn";
            this.drwNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drwDateDataGridViewTextBoxColumn
            // 
            this.drwDateDataGridViewTextBoxColumn.DataPropertyName = "drwDate";
            this.drwDateDataGridViewTextBoxColumn.HeaderText = "drwDate";
            this.drwDateDataGridViewTextBoxColumn.Name = "drwDateDataGridViewTextBoxColumn";
            this.drwDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lottoBindingSource
            // 
            this.lottoBindingSource.DataSource = typeof(_20210617.Lotto);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // sabeonDataGridViewTextBoxColumn
            // 
            this.sabeonDataGridViewTextBoxColumn.DataPropertyName = "sabeon";
            this.sabeonDataGridViewTextBoxColumn.HeaderText = "sabeon";
            this.sabeonDataGridViewTextBoxColumn.Name = "sabeonDataGridViewTextBoxColumn";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(_20210617.Doctor);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(868, 12);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(427, 335);
            this.chart2.TabIndex = 10;
            this.chart2.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 527);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button_jsonAPI);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_sabeon);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_read);
            this.Controls.Add(this.button_write);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_write;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabeonDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_sabeon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button_jsonAPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwNo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwNo2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwNo3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwNo4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwNo5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwNo6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lottoBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

