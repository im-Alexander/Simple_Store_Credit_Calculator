namespace SimpleSCCalculator
{
    public partial class Form1 : Form
    {
        // public instance variables
        public decimal numberOfPlayers;
        public decimal entryCost;
        public decimal everybodyGets;
        public decimal totalPoints;
        public decimal totalStoreCredit;
        public decimal storeCreditReserved;
        public decimal storeCreditPerPoint;
        public decimal percentage;
        public decimal playerPoints;
        public decimal storeCreditReceived;

        // when form is opened
        public Form1()
        {
            InitializeComponent();
            numberOfPlayers = numberOfPlayersNum.Value;
            entryCost = entryCostNum.Value;
            everybodyGets = everybodyGetsNum.Value;
            totalPoints = totalPointsNum.Value;
            percentage = percentageNum.Value;
            playerPoints = playerPointsNum.Value;
            updateTotalStoreCredit();
            updateStoreCreditReserved();
            updateStoreCreditPerPoint();
            updateStoreCreditReceived();
        }

        // when number of players is updated
        private void numberOfPlayersNum_ValueChanged(object sender, EventArgs e)
        {
            numberOfPlayers = numberOfPlayersNum.Value;
            updateTotalStoreCredit();
            updateStoreCreditReserved();
            updateStoreCreditPerPoint();
            updateStoreCreditReceived();
        }

        // when entry cost is updated
        private void entryCostNum_ValueChanged(object sender, EventArgs e)
        {
            entryCost = entryCostNum.Value;
            updateTotalStoreCredit();
            updateStoreCreditPerPoint();
            updateStoreCreditReceived();
        }

        // when everybody gets is updated
        private void everybodyGetsNum_ValueChanged(object sender, EventArgs e)
        {
            everybodyGets = everybodyGetsNum.Value;
            updateStoreCreditReserved();
            updateStoreCreditPerPoint();
            updateStoreCreditReceived();
        }

        // when total points is updated
        private void totalPointsNum_ValueChanged(object sender, EventArgs e)
        {
            totalPoints = totalPointsNum.Value;
            updateStoreCreditPerPoint();
            updateStoreCreditReceived();
        }

        // when player points is updated
        private void playerPointsNum_ValueChanged(object sender, EventArgs e)
        {
            playerPoints = playerPointsNum.Value;
            updateStoreCreditReceived();
        }

        // when percentage is changed
        private void percentageNum_ValueChanged(object sender, EventArgs e)
        {
            percentage = percentageNum.Value;
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
            totalStoreCredit = numberOfPlayers * entryCost;
            totalStoreCreditTbx.Text = totalStoreCredit.ToString();
        }

        // updates store credit reserved
        private void updateStoreCreditReserved()
        {
            storeCreditReserved = numberOfPlayers * everybodyGets;
            storeCreditReservedTbx.Text = storeCreditReserved.ToString();
        }

        // updates store credit per point
        private void updateStoreCreditPerPoint()
        {
            storeCreditReserved = numberOfPlayers * everybodyGets;
            totalStoreCredit = numberOfPlayers * entryCost;
            totalPoints = totalPointsNum.Value;

            storeCreditPerPoint = Math.Round(((totalStoreCredit - storeCreditReserved) / totalPoints), 2);
            storeCreditPerPointTbx.Text = "$" + storeCreditPerPoint.ToString();
        }

        // updates store credit received
        private void updateStoreCreditReceived()
        {
            everybodyGets = everybodyGetsNum.Value;
            storeCreditReserved = numberOfPlayersNum.Value * everybodyGetsNum.Value;
            totalStoreCredit = numberOfPlayersNum.Value * entryCostNum.Value;
            totalPoints = totalPointsNum.Value;
            percentage = percentageNum.Value;

            storeCreditPerPoint = (totalStoreCredit - storeCreditReserved) / totalPoints;
            storeCreditReceived = everybodyGets + (storeCreditPerPoint * playerPointsNum.Value);
            storeCreditReceived = storeCreditReceived * (percentage / 100);

            storeCreditReceived = Math.Round(storeCreditReceived, 2);
            storeCreditReceivedTbx.Text = "$" + storeCreditReceived.ToString();
        }

        // updates prizing list box
        private void updatePrizingListbox()
        {
            string prizing = playerPoints.ToString() + " points @ " + percentage.ToString() + "% = " + storeCreditReceived.ToString();
            prizingLbx.Items.Add(prizing);
        }

        // clears prizing list box
        private void emptyPrizingListbox()
        {
            prizingLbx.Items.Clear();
        }

        
    }
}
