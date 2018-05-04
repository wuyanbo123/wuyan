using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jieye
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Schedule schedule = new Schedule();
        cinema cinema = new cinema();
        private void 获取新放映列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            schedule.LoadItems();
            InitTreeView();

        }
        
        
        Dictionary<string, Label> labels = new Dictionary<string, Label>();
        private void Form1_Load(object sender, EventArgs e)
        {
            InitTreeView();// 初始化TreeView控件
            Seats();// 座位加载
         
            
        }
        /// <summary>
        /// 座位加载
        /// </summary>
        private void Seats()
        {
            int seatRow = 6;
            int seatLine = 5;

            for (int i = 0; i < seatRow; i++)
            {
                for (int j = 0; j < seatLine; j++)
                {
                    Label cui = new Label();
                    cui.BackColor = Color.Yellow;
                    cui.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular,
                        System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    cui.AutoSize = false;
                    cui.Size = new System.Drawing.Size(50, 25);
                    cui.Text = (j + 1).ToString() + "-" + (i + 1).ToString();
                    cui.TextAlign = ContentAlignment.MiddleCenter;
                    cui.Location = new Point(30 + (i * 90), 30 + (j * 60));
                    cui.Click += new System.EventHandler(lblSeat_Click);
                    tabPage2.Controls.Add(cui);
                    labels.Add(cui.Text, cui);
                    Seat seat = new Seat((j + 1).ToString() + "-" + (i + 1).ToString(), Color.Yellow);
                    //保存的座位
                    cinema.Seats.Add(seat.SeatNum, seat);
                }

            }
        }

        private void lblSeat_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
       /// <summary>
       /// 初始化TreeView控件
       /// </summary>
        private void InitTreeView()
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();
            string movieName = null;
            TreeNode movieNode = null;
            schedule.LoadItems();

            foreach (KeyValuePair<string, Scheduleltem> item in schedule.Items)
            {
                if (movieName != item.Value.Movie.MovieName)
                {
                    movieNode = new TreeNode(item.Value.Movie.MovieName);
                    treeView1.Nodes.Add(movieNode);
                }
                TreeNode timeNode = new TreeNode(item.Value.Time);
                movieNode.Nodes.Add(timeNode);
                movieName = item.Value.Movie.MovieName;
            }
            treeView1.EndUpdate();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        string Key = string.Empty;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node == null) return;
            if (node.Level != 0)return;
            Key = treeView1.SelectedNode.Text;
            6this.label17.Text = schedule.Items[Key].Movie.MovieName;
            this.label9.Text = schedule.Items[Key].Movie.Director;
            this.label10.Text = schedule.Items[Key].Movie.Actor;
            this.label11.Text = schedule.Items[Key].Movie.Price;
            this.label12.Text = schedule.Items[Key].Movie.Time;
            this.label13.Text = schedule.Items[Key].Movie.movieType.ToString();
            this.pictureBox1.Image = Image.FromFile(schedule.Items[Key].Movie.Poster);

            this.label14.Text="";
            
        }
    }
}
