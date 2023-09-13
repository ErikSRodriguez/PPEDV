using Microsoft.Data.SqlClient;
using System.ComponentModel.Design.Serialization;
using System.Threading.Tasks.Sources;

namespace HalloAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void withoutThreadButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = i;
                Application.DoEvents(); //pfusch!!!!
                Thread.Sleep(3000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Control)sender).Enabled = false;

            Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    //progressBar1.Value = i;
                    progressBar1.Invoke(() => progressBar1.Value = i);
                    Thread.Sleep(30);
                }
                this.Invoke(() => ((Control)sender).Enabled = true);
            });

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            ((Control)sender).Enabled = false;

            TaskScheduler ts = TaskScheduler.FromCurrentSynchronizationContext();

            var tt = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Task.Factory.StartNew(() => progressBar1.Value = i, cts.Token, TaskCreationOptions.None, ts);
                    Thread.Sleep(30);

                    //if (i >= 88)
                    //    throw new Exception();

                    if (cts.IsCancellationRequested)
                        break;
                }
                this.Invoke(() => ((Control)sender).Enabled = true);
            });

            tt.ContinueWith(t => MessageBox.Show("Error"), TaskContinuationOptions.OnlyOnFaulted);
            tt.ContinueWith(t => MessageBox.Show("OK"), TaskContinuationOptions.OnlyOnRanToCompletion);

        }

        CancellationTokenSource cts;
        private void button3_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            ((Control)sender).Enabled = false;
            cts = new CancellationTokenSource();

            try
            {
                for (int i = 0; i < 100; i++)
                {
                    progressBar1.Value = i;
                    await Task.Delay(30, cts.Token);
                }
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("Canceld");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

            ((Control)sender).Enabled = true;
        }

        public long CalcValuesVerySlow(int a)
        {
            Thread.Sleep(5000);

            return 42 * a;
        }

        public Task<long> CalcValuesVerySlowAsync(int a)
        {
            var ttt = Task.Run(() => CalcValuesVerySlow(a));
            //ttt.ContinueWith(t => throw t.Exception, TaskContinuationOptions.OnlyOnFaulted);
            return ttt;
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            try
            {
                long res = (await CalcValuesVerySlowAsync(122));
                MessageBox.Show($"Slow:{res}");
            }
            catch (Exception)
            {
                MessageBox.Show("AAAAAA");
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            var conString = "Server=.;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=true;";
            conString = "Connection Timeout=20;Server=(localdb)\\mssqllocaldb;Database=NORTHWND;Trusted_Connection=True;TrustServerCertificate=true;";

            using var con = new SqlConnection(conString);
            try
            {
                progressBar1.Style = ProgressBarStyle.Marquee;
                await con.OpenAsync();

                using var cmd = con.CreateCommand();
                cmd.CommandText = $"WAITFOR DELAY '00:00:5';SELECT COUNT(*) FROM Customers WHERE CompanyName LIKE @such";
                cmd.Parameters.AddWithValue("@such", textBox1.Text + "%");
                if (await cmd.ExecuteScalarAsync() is int count)
                {
                    MessageBox.Show($"{count} Customers in DB");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler :-(\n{ex.Message}");
            }
            progressBar1.Style = ProgressBarStyle.Blocks;
        
        } 


    }
}
