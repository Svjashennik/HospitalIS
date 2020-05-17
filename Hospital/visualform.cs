using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hospital
{
    public partial class visualform : Form
    {
        public List<Department> departments;
        public List<Pacient> lst_people;
        public List<Pacient> filt_people;
        public RadioButton plot;
        public visualform()
        {
            InitializeComponent();
            plot = depplotcheck;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            depplotcheck.Checked = true;
            doesrad.Checked = true;
            depbox.Enabled = false;
        }


        private void depplotcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!depplotcheck.Checked) return;
            plot = depplotcheck;
            chart1.Series[0].Points.Clear();
            bool check = true;
            if (hearrad.Checked) check = true;
            if (nothearrad.Checked) check = false;
            int count;
            foreach (Department dep in departments)
            {
                if (dep.people.Count == 0) continue;
                count = dep.countpac;
                if (hearrad.Checked) count = dep.people.FindAll(pac => pac.hear == check).Count;
                if (nothearrad.Checked) count = dep.people.FindAll(pac => pac.hear == check).Count;
                chart1.Series[0].Points.AddXY(dep.name, count);
            }
        }

        private void roomplotcheck_CheckedChanged(object sender, EventArgs e)
        {

            if (!roomplotcheck.Checked) return;
            plot = roomplotcheck;
            filt_people = lst_people;
            if (depcheck.Checked) filt_people = filt_people.FindAll(pac => pac.depart_name == depbox.Text);
            if (hearrad.Checked) filt_people = filt_people.FindAll(pac => pac.hear);
            if (nothearrad.Checked) filt_people = filt_people.FindAll(pac => !pac.hear);
            chart1.Series[0].Points.Clear();
            Dictionary<int, int> roo = new Dictionary<int, int>();
            foreach (Pacient pac in filt_people)
            {
                if (!roo.ContainsKey(pac.room)) roo[pac.room] = 0;
                roo[pac.room]++;
            }
            foreach (KeyValuePair<int, int> keyValue in roo)
            {
                chart1.Series[0].Points.AddXY(keyValue.Key.ToString(), keyValue.Value);
            }
        }

        private void dateaddcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!dateaddcheck.Checked) return;
            plot = dateaddcheck;
            filt_people = lst_people;
            if (depcheck.Checked) filt_people = filt_people.FindAll(pac => pac.depart_name == depbox.Text);
            if (hearrad.Checked) filt_people = filt_people.FindAll(pac => pac.hear);
            if (nothearrad.Checked) filt_people = filt_people.FindAll(pac => !pac.hear);
            chart1.Series[0].Points.Clear();
            Dictionary<string, int> roo = new Dictionary<string, int>();
            foreach (Pacient pac in filt_people)
            {
                if (!roo.ContainsKey(pac.date_add.ToString("Y"))) roo[pac.date_add.ToString("Y")] = 0;
                roo[pac.date_add.ToString("Y")]++;
            }
            foreach (KeyValuePair<string, int> keyValue in roo)
            {
                chart1.Series[0].Points.AddXY(keyValue.Key, keyValue.Value);
            }
        }

        private void dateclosecheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!dateclosecheck.Checked) return;
            plot = dateclosecheck;
            filt_people = lst_people;
            if (depcheck.Checked) filt_people = filt_people.FindAll(pac => pac.depart_name == depbox.Text);
            if (hearrad.Checked) filt_people = filt_people.FindAll(pac => pac.hear);
            if (nothearrad.Checked) filt_people = filt_people.FindAll(pac => !pac.hear);
            chart1.Series[0].Points.Clear();
            Dictionary<string, int> roo = new Dictionary<string, int>();
            foreach (Pacient pac in filt_people)
            {
                if (!roo.ContainsKey(pac.date_close.ToString("Y"))) roo[pac.date_close.ToString("Y")] = 0;
                roo[pac.date_close.ToString("Y")]++;
            }
            foreach (KeyValuePair<string, int> keyValue in roo)
            {
                chart1.Series[0].Points.AddXY(keyValue.Key, keyValue.Value);
            }
        }

        private void syndormplotcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!syndromplotcheck.Checked) return;
            plot = syndromplotcheck;
            filt_people = lst_people;
            if (depcheck.Checked) filt_people = filt_people.FindAll(pac => pac.depart_name == depbox.Text);
            if (hearrad.Checked) filt_people = filt_people.FindAll(pac => pac.hear);
            if (nothearrad.Checked) filt_people = filt_people.FindAll(pac => !pac.hear);
            chart1.Series[0].Points.Clear();
            Dictionary<string, int> roo = new Dictionary<string, int>();
            foreach (Pacient pac in filt_people)
            {
                if (!roo.ContainsKey(pac.syndrom)) roo[pac.syndrom] = 0;
                roo[pac.syndrom]++;
            }
            foreach (KeyValuePair<string, int> keyValue in roo)
            {
                chart1.Series[0].Points.AddXY(keyValue.Key, keyValue.Value);
            }
        }


        private void ageplotcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!ageplotcheck.Checked) return;
            plot = ageplotcheck;
            filt_people = lst_people;
            if (depcheck.Checked) filt_people = filt_people.FindAll(pac => pac.depart_name == depbox.Text);
            if (hearrad.Checked) filt_people = filt_people.FindAll(pac => pac.hear);
            if (nothearrad.Checked) filt_people = filt_people.FindAll(pac => !pac.hear);
            chart1.Series[0].Points.Clear();
            Dictionary<int, int> roo = new Dictionary<int, int>();
            foreach (Pacient pac in filt_people)
            {
                if (!roo.ContainsKey(pac.age)) roo[pac.age] = 0;
                roo[pac.age]++;
            }
            foreach (KeyValuePair<int, int> keyValue in roo)
            {
                chart1.Series[0].Points.AddXY(keyValue.Key, keyValue.Value);
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (depcheck.Checked) depbox.Enabled = true;
            else depbox.Enabled = false;
            plot.Checked = false;
            plot.Checked = true;
        }

        private void columnplot_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        private void pieplot_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private void barplot_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
        }

        private void pointplot_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
        }

        private void boxplot_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
        }

        private void hearrad_CheckedChanged(object sender, EventArgs e)
        {
            plot.Checked = false;
            plot.Checked = true;
        }

        private void nothearrad_CheckedChanged(object sender, EventArgs e)
        {
            plot.Checked = false;
            plot.Checked = true;
        }

        private void doesrad_CheckedChanged(object sender, EventArgs e)
        {
            plot.Checked = false;
            plot.Checked = true;
        }

        private void depbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            plot.Checked = false;
            plot.Checked = true;
        }
    }
}
