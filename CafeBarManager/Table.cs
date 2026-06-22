using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeBarManager
{

    public enum TableStatus
    {
        Free = 0,               // green
        OccupiedUnserved = 1,   // yello
        OccupiedServed = 2      // red
    }
    public class Table
    {
        public int TableNumber { get; private set; }

        public TableStatus Status { get; set; }
        public Order CurrentOrder { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }


        public DateTime? SeatingTime { get; private set; }
        public DateTime? OrderServedTime { get; private set; }
        public bool IsRequestingBill { get; set; }


        public List<TimeSpan> RoundWaitTimes { get; private set; } = new List<TimeSpan>();


        public Table(int tableNumber, int x, int y, int width = 80, int height = 80)
        {
            this.TableNumber = tableNumber;
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;

            this.Status = TableStatus.Free;
            this.CurrentOrder = null; 
            this.IsRequestingBill = false;
            this.RoundWaitTimes = new List<TimeSpan>();
        }

        public Color GetStatusColor()
        {
            switch (this.Status)
            {
                case TableStatus.Free:
                    return Color.Green;
                case TableStatus.OccupiedUnserved:
                    return Color.Yellow; 
                case TableStatus.OccupiedServed:
                    return Color.Red;
                default:
                    return Color.Gray;
            }
        }


        public bool IsClicked(int mouseX, int mouseY)
        {

            if (mouseX >= this.X && mouseX <= (this.X + this.Width))
            {
                if (mouseY >= this.Y && mouseY <= (this.Y + this.Height))
                {
                    return true;
                }
            }
            return false;
        }

        public void GuestsSeated(string waiterName)
        {

            this.Status = TableStatus.OccupiedUnserved;
            this.SeatingTime = DateTime.Now;
            this.OrderServedTime = null;
            this.IsRequestingBill = false;

           
            if (this.CurrentOrder == null)
            {
                this.CurrentOrder = new Order(this.TableNumber, waiterName);
            }
        }

        public void OrderServed()
        {
            if (this.Status != TableStatus.OccupiedUnserved)
                throw new InvalidOperationException("Масата мора прво да има нарачка за да биде услужена.");

            this.Status = TableStatus.OccupiedServed;
            this.OrderServedTime = DateTime.Now;


            TimeSpan durationOfThisRound = this.OrderServedTime.Value - this.SeatingTime.Value;
            this.RoundWaitTimes.Add(durationOfThisRound);
        }

        public TimeSpan? GetWaitTime()
        {
            if (SeatingTime == null || OrderServedTime == null) return null;
            return OrderServedTime.Value - SeatingTime.Value;
        }


        public TimeSpan? GetCurrentWaitTime()
        {
            if (this.Status != TableStatus.OccupiedUnserved || SeatingTime == null) return null;
            return DateTime.Now - SeatingTime.Value;
        }


        public string GetEfficiencyRating()
        {
            TimeSpan? wait = GetWaitTime();
            if (wait == null) return "—";
            double seconds = wait.Value.TotalSeconds;

            if (seconds <= 120) return $"✓ Одлично ({wait.Value.Minutes:00}:{wait.Value.Seconds:00})";
            if (seconds <= 300) return $"● Добро ({wait.Value.Minutes:00}:{wait.Value.Seconds:00})";
            return $"✗ Бавно ({wait.Value.Minutes:00}:{wait.Value.Seconds:00})";
        }

        public Order ClearTable()
        {
            if (CurrentOrder != null)
            {
                CurrentOrder.CompletePayment();
            }
            Order completedOrder = CurrentOrder;

            this.Status = TableStatus.Free;
            this.SeatingTime = null;
            this.OrderServedTime = null;
            this.IsRequestingBill = false;
            this.CurrentOrder = null;

            return completedOrder;
        }

        public TimeSpan GetAverageWaitTime()
        {
            if (RoundWaitTimes.Count == 0)
                return TimeSpan.Zero;

            double totalSeconds = 0;
            foreach (TimeSpan t in RoundWaitTimes)
            {
                totalSeconds += t.TotalSeconds;
            }

            double averageSeconds = totalSeconds / RoundWaitTimes.Count;
            return TimeSpan.FromSeconds(averageSeconds);
        }


        public void NewRoundStarted()
        {
            if (Status != TableStatus.OccupiedServed)
                return;

            Status = TableStatus.OccupiedUnserved; 
            SeatingTime = DateTime.Now;           
            OrderServedTime = null;               
        }

    }
}
