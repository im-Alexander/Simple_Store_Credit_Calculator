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
            updateStoreCreditRecieved();
        }

        // when number of players is updated
        private void numberOfPlayersNum_ValueChanged(object sender, EventArgs e)
        {
            updateTotalStoreCredit();
            updateStoreCreditReserved();
            updateStoreCreditPerPoint();
            updateStoreCreditRecieved();
        }

        // when entry cost is updated
        private void entryCostNum_ValueChanged(object sender, EventArgs e)
        {
            updateTotalStoreCredit();
            updateStoreCreditPerPoint();
            updateStoreCreditRecieved();
        }

        // when everybody gets is updated
        private void everybodyGetsNum_ValueChanged(object sender, EventArgs e)
        {
            updateStoreCreditReserved();
            updateStoreCreditPerPoint();
            updateStoreCreditRecieved();
        }

        // when total points is updated
        private void totalPointsNum_ValueChanged(object sender, EventArgs e)
        {
            updateStoreCreditPerPoint();
            updateStoreCreditRecieved();
        }

        // when player points is updated
        private void playerPointsNum_ValueChanged(object sender, EventArgs e)
        {
            updateStoreCreditRecieved();
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

        // updates store credit recieved
        private void updateStoreCreditRecieved()
        {
            decimal everbodyGets = everybodyGetsNum.Value;
            decimal storeCreditReserved = numberOfPlayersNum.Value * everybodyGetsNum.Value;
            decimal totalStoreCredit = numberOfPlayersNum.Value * entryCostNum.Value;
            decimal totalPoints = totalPointsNum.Value;

            decimal storeCreditPerPoint = (totalStoreCredit - storeCreditReserved) / totalPoints;
            decimal StoreCreditRecieved = everbodyGets + (storeCreditPerPoint * playerPointsNum.Value);
            decimal roundedValue = Math.Round(StoreCreditRecieved, 2);
            storeCreditReceivedTbx.Text = "$" + roundedValue.ToString();
        }
    }
}
