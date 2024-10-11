

   public class TicketBookEvent
    {
    public delegate void MyActive();
    public static event MyActive MyActivePic;
    public void RunEvent()
    {
        if (MyActivePic!=null)
        {
            MyActivePic();
        }
    }

    }

