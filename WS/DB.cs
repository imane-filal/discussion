using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS
{
    
    public class DB
    {
        static List<Participant> participants = new List<Participant>();

      
       static public void Add(string mypseudo)
        {
            participants.Add(new Participant(mypseudo));
        }

        static public List<Participant> GetParticipants()
        {
            return participants;
        }
        static public bool Exists(string Mypseudo)
        {
            foreach (Participant p in participants)
            {
                if (p.Pseudo.Equals(Mypseudo)) return true;
            }
            return false;
        }
    }
}