using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLib
{
    public class OurObject // возможно, следует поменять назване на "раздел"
    {
        private string nameChapter; // возможно, поменять на enum 
        private Map _map;
        private Question _question;
        private Answer _answer;
        OurObject(Map map, Question question, Answer answer)
        {
            _map = map;
            _question = question;
            _answer = answer;
        }
        public Map Map
        {
            get { return _map; }
            set { _map = value; }
        }
        public Question Question
        {
            get { return _question; }
            set { _question = value; }
        }
        public Answer Answer
        {
            get { return _answer; }
            set { _answer = value; }
        }

    }
    public class Map
    {
        //добавление новой карты
    }
    public class Question
    {
        private string _question;
        //добавление нового вопроса
        
    }
    public class Answer
    {
        string[] _answerOptions;
        private int _numberOfAnswerOption;
        private int _correctAnswer;
        private bool _correctInput;
        private int _counterCorrectAnswer;
        //добавление нового ответа (во время создания нового задания)
        //проверка на корректность ввода ответа на задание учеником
        //счетчик правильных ответов
    }
    public class Identification
    {
        private string _password;
        private string _userName;
        // проверка правильности ввода пароля
        // вытаскивание из json-файла информации о пользователях 
        // у нас только один пользователь? 
        // нужно ли делать приложение многопользовательским? Или достаточно одного юзера?
    }
}
