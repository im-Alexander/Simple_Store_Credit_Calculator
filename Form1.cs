namespace SimpleSCCalculator
{
    public partial class Form1 : Form
    {
        // when form is opened
        public Form1()
        {
            InitializeComponent();
            updateTotalStoreCredit();
            updateStoreCreditReserved();
            updateStoreCreditPerPoint();
            updateStoreCreditReceived();
        }

        // when number of players is updated
        private void numberOfPlayersNum_ValueChanged(object sender, EventArgs e)
        {
            updateTotalStoreCredit();
            updateStoreCreditReserved();
            updateStoreCreditPerPoint();
            updateStoreCreditReceived();
        }

        // when entry cost is updated
        private void entryCostNum_ValueChanged(object sender, EventArgs e)
        {
            updateTotalStoreCredit();
            updateStoreCreditPerPoint();
            updateStoreCreditReceived();
        }

        // when everybody gets is updated
        private void everybodyGetsNum_ValueChanged(object sender, EventArgs e)
        {
            updateStoreCreditReserved();
            updateStoreCreditPerPoint();
            updateStoreCreditReceived();
        }

        // when total points is updated
        private void totalPointsNum_ValueChanged(object sender, EventArgs e)
        {
            updateStoreCreditPerPoint();
            updateStoreCreditReceived();
        }

        // when player points is updated
        private void playerPointsNum_ValueChanged(object sender, EventArgs e)
        {
            updateStoreCreditReceived();
        }

        // when percentage is changed
        private void percentageNum_ValueChanged(object sender, EventArgs e)
        {
            updateStoreCreditReceived();
        }

        // when add to list button is clicked
        private void addToListBtn_Click(object sender, EventArgs e)
        {
            updatePrizingListbox();
        }

        // when clear list button is clicked
        private void clearListBtn_Click(object sender, EventArgs e)
        {
            emptyPrizingListbox();
        }

        

        // update total store credit
        private void updateTotalStoreCredit()
        {
            decimal totalStoreCredit = numberOfPlayersNum.Value * entryCostNum.Value;
            totalStoreCreditTbx.Text = totalStoreCredit.ToString();
        }

        // updates store credit reserved
        private void updateStoreCreditReserved()
        {
            decimal storeCreditReserved = numberOfPlayersNum.Value * everybodyGetsNum.Value;
            storeCreditReservedTbx.Text = storeCreditReserved.ToString();
        }

        // updates store credit per point
        private void updateStoreCreditPerPoint()
        {
            decimal storeCreditReserved = numberOfPlayersNum.Value * everybodyGetsNum.Value;
            decimal totalStoreCredit = numberOfPlayersNum.Value * entryCostNum.Value;
            decimal totalPoints = totalPointsNum.Value;

            decimal storeCreditPerPoint = (totalStoreCredit - storeCreditReserved) / totalPoints;
            decimal roundedValue = Math.Round(storeCreditPerPoint, 2);
            storeCreditPerPointTbx.Text = "$" + roundedValue.ToString();
        }

        // updates store credit received
        private void updateStoreCreditReceived()
        {
            decimal everbodyGets = everybodyGetsNum.Value;
            decimal storeCreditReserved = numberOfPlayersNum.Value * everybodyGetsNum.Value;
            decimal totalStoreCredit = numberOfPlayersNum.Value * entryCostNum.Value;
            decimal totalPoints = totalPointsNum.Value;
            decimal percentage = percentageNum.Value;

            decimal storeCreditPerPoint = (totalStoreCredit - storeCreditReserved) / totalPoints;
            decimal storeCreditRecieved = everbodyGets + (storeCreditPerPoint * playerPointsNum.Value);
            storeCreditRecieved = storeCreditRecieved * (percentage / 100);

            decimal roundedValue = Math.Round(storeCreditRecieved, 2);
            storeCreditReceivedTbx.Text = "$" + roundedValue.ToString();
        }

        // updates prizing list box
        private void updatePrizingListbox()
        {
            string prizing = playerPointsNum.Value.ToString() + " points @ " + percentageNum.Value.ToString() + "% = " + storeCreditReceivedTbx.Text;
            prizingLbx.Items.Add(prizing);
        }

        // clears prizing list box
        private void emptyPrizingListbox()
        {
            prizingLbx.Items.Clear();
        }

        
    }
}
