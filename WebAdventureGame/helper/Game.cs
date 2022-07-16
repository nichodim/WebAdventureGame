using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAdventureGame.helper
{

    public class GameItem
    {
        public GameItem(int _id, string _question, string _answer, int? _parentId)
        {
            id = _id;
            question = _question;
            answer = _answer;
            parentId = _parentId;
        }
        public int id { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
        public int? parentId = null;
    }
}