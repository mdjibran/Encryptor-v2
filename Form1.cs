using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace Encryptor
{
    public partial class Form1 : Form
    {
        string originalText;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {                
                strtworkingontext();                
            }
            else
                MessageBox.Show("Please Enter text to Encrypt", "Encryptor");
        }

        private void strtworkingontext()
        {
            richTextBox2.Text = "";
            originalText = richTextBox1.Text;


            char[] words = originalText.ToCharArray();
            if ((words.Length) > 10)
            {
                richTextBox2.Text = "ABNHJUIDEH";
                for (int i = 0; i <= words.Length - 1; i++)
                {
                    
                    char alphabet = words[i];
                    switch (alphabet)
                    {
                        case ' ':
                            richTextBox2.Text += "ABBOTSHIPS";
                            break;
                        case '\n':
                            richTextBox2.Text += "ARCHICARPS";
                            break;
                        case '\r' :
                            richTextBox2.Text += "ARCHRIVALS";
                            break;
                        case  '\t':
                            richTextBox2.Text += "ARCUATIONS";
                            break;
                        case 'a':
                            richTextBox2.Text += "ABCOULOMBS";
                            break;
                        case 'b':
                            richTextBox2.Text += "ABDOMINALS";
                            break;
                        case 'c':
                            richTextBox2.Text += "ABROGATORS";
                            break;
                        case 'd':
                            richTextBox2.Text += "ABSOLVENTS";
                            break;
                        case 'e':
                            richTextBox2.Text += "ACCEDENCES";
                            break;
                        case 'f':
                            richTextBox2.Text += "ACCOLADING";
                            break;
                        case 'g':
                            richTextBox2.Text += "ACETIFIERS";
                            break;
                        case 'h':
                            richTextBox2.Text += "ACROSPIRES";
                            break;
                        case 'i':
                            richTextBox2.Text += "ACUMINATED";
                            break;
                        case 'j':
                            richTextBox2.Text += "ACUMINATES";
                            break;
                        case 'k':
                            richTextBox2.Text += "ADDRESSORS";
                            break;
                        case 'l':
                            richTextBox2.Text += "ADEMPTIONS";
                            break;
                        case 'm':
                            richTextBox2.Text += "ADIPOCERES";
                            break;
                        case 'n':
                            richTextBox2.Text += "ADJACENCES";
                            break;
                        case 'o':
                            richTextBox2.Text += "ADMONITORS";
                            break;
                        case 'p':
                            richTextBox2.Text += "ADRENALINS";
                            break;
                        case 'q':
                            richTextBox2.Text += "AEROPAUSES";
                            break;
                        case 'r':
                            richTextBox2.Text += "AEROPHOBES";
                            break;
                        case 's':
                            richTextBox2.Text += "AEROPHORES";
                            break;
                        case 't':
                            richTextBox2.Text += "AEROPHYTES";
                            break;
                        case 'u':
                            richTextBox2.Text += "AEROPULSES";
                            break;
                        case 'v':
                            richTextBox2.Text += "AEROSCOPES";
                            break;
                        case 'w':
                            richTextBox2.Text += "AESTHESIAS";
                            break;
                        case 'x':
                            richTextBox2.Text += "AFFIRMANTS";
                            break;
                        case 'y':
                            richTextBox2.Text += "AFFIXTURES";
                            break;
                        case 'z':
                            richTextBox2.Text += "AFFLICTERS";
                            break;

                        case 'A':
                            richTextBox2.Text += "AFFRICATED";
                            break;
                        case 'B':
                            richTextBox2.Text += "AFTERDAMPS";
                            break;
                        case 'C':
                            richTextBox2.Text += "AFTERLIFES";
                            break;
                        case 'D':
                            richTextBox2.Text += "AFTERPAINS";
                            break;
                        case 'E':
                            richTextBox2.Text += "AGALACTIAS";
                            break;
                        case 'F':
                            richTextBox2.Text += "AGATEWARES";
                            break;
                        case 'G':
                            richTextBox2.Text += "AIRSTRIKES";
                            break;
                        case 'H':
                            richTextBox2.Text += "ALBERTITES";
                            break;
                        case 'I':
                            richTextBox2.Text += "ALBUTEROLS";
                            break;
                        case 'J':
                            richTextBox2.Text += "ALFILERIAS";
                            break;
                        case 'K':
                            richTextBox2.Text += "ALGARROBOS";
                            break;
                        case 'L':
                            richTextBox2.Text += "ALGOMETERS";
                            break;
                        case 'M':
                            richTextBox2.Text += "ALIZARINES";
                            break;
                        case 'N':
                            richTextBox2.Text += "ALKALIZERS";
                            break;
                        case 'O':
                            richTextBox2.Text += "ALLANTOIDS";
                            break;
                        case 'P':
                            richTextBox2.Text += "ALLEGIANTS";
                            break;
                        case 'Q':
                            richTextBox2.Text += "ALLEVIANTS";
                            break;
                        case 'R':
                            richTextBox2.Text += "ALLOPLASMS";
                            break;
                        case 'S':
                            richTextBox2.Text += "ALLOWABLES";
                            break;
                        case 'T':
                            richTextBox2.Text += "ALTERITIES";
                            break;
                        case 'U':
                            richTextBox2.Text += "ALTERNANTS";
                            break;
                        case 'V':
                            richTextBox2.Text += "ALTIGRAPHS";
                            break;
                        case 'W':
                            richTextBox2.Text += "ALUMSTONES";
                            break;
                        case 'X':
                            richTextBox2.Text += "AMAZONIANS";
                            break;
                        case 'Y':
                            richTextBox2.Text += "AMBULATORS";
                            break;
                        case 'Z':
                            richTextBox2.Text += "AMBULETTES";
                            break;


                        case '0':
                            richTextBox2.Text += "AMORPHISMS";
                            break;
                        case '1':
                            richTextBox2.Text += "AMPUTATORS";
                            break;
                        case '2':
                            richTextBox2.Text += "AMSINCKIAS";
                            break;
                        case '3':
                            richTextBox2.Text += "ANAEROBIUM";
                            break;
                        case '4':
                            richTextBox2.Text += "ANALOGISMS";
                            break;
                        case '5':
                            richTextBox2.Text += "ANARTHRIAS";
                            break;
                        case '6':
                            richTextBox2.Text += "ANCHYLOSED";
                            break;
                        case '7':
                            richTextBox2.Text += "ANCHYLOSES";
                            break;
                        case '8':
                            richTextBox2.Text += "ANGOSTURAS";
                            break;
                        case '9':
                            richTextBox2.Text += "ANIMALISTS";
                            break;


                        case '`':
                            richTextBox2.Text += "ANIMATISMS";
                            break;
                        case '~':
                            richTextBox2.Text += "ANIMATISTS";
                            break;
                        case '!':
                            richTextBox2.Text += "ANOVULANTS";
                            break;
                        case '@':
                            richTextBox2.Text += "ANTALKALIS";
                            break;
                        case '#':
                            richTextBox2.Text += "ANTIBUSERS";
                            break;
                        case '$':
                            richTextBox2.Text += "ANTICHLORS";
                            break;
                        case '%':
                            richTextBox2.Text += "ANTIELITES";
                            break;
                        case '^':
                            richTextBox2.Text += "ANTILIFERS";
                            break;
                        case '&':
                            richTextBox2.Text += "ANTIMONYLS";
                            break;
                        case '*':
                            richTextBox2.Text += "ANTIMUSICS";
                            break;
                        case '(':
                            richTextBox2.Text += "ANTINUKERS";
                            break;
                        case ')':
                            richTextBox2.Text += "ANTIPASTOS";
                            break;
                        case '-':
                            richTextBox2.Text += "ANTIRADARS";
                            break;
                        case '_':
                            richTextBox2.Text += "ANTISHOCKS";
                            break;
                        case '=':
                            richTextBox2.Text += "ANTISTYLES";
                            break;
                        case '+':
                            richTextBox2.Text += "ANTITRADES";
                            break;
                        case '\\':
                            richTextBox2.Text += "ANTITRAGUS";
                            break;
                        case '|':
                            richTextBox2.Text += "ANTITUMORS";
                            break;
                        case '.':
                            richTextBox2.Text += "ANTIVENOMS";
                            break;
                        case '/':
                            richTextBox2.Text += "APATOSAURS";
                            break;
                        case '>':
                            richTextBox2.Text += "APHORIZERS";
                            break;
                        case '<':
                            richTextBox2.Text += "APHRODITES";
                            break;
                        case ',':
                            richTextBox2.Text += "APOCOPATED";
                            break;
                        case '{':
                            richTextBox2.Text += "APOCOPATES";
                            break;
                        case '}':
                            richTextBox2.Text += "APOSTILLES";
                            break;
                        case '[':
                            richTextBox2.Text += "APPALOOSAS";
                            break;
                        case ']':
                            richTextBox2.Text += "APPENDENTS";
                            break;
                        case ';':
                            richTextBox2.Text += "APPOINTERS";
                            break;
                        case ':':
                            richTextBox2.Text += "APPOINTORS";
                            break;
                        case '"':
                            richTextBox2.Text += "AQUAFARMED";
                            break;
                        case '\'':
                            richTextBox2.Text += "ARCHAIZERS";
                            break;

                        default:
                            richTextBox2.Text += alphabet;
                            break;

                    }                    
                }
                MessageBox.Show("Your mesage has been Encrypted", "Encryptor");
            }
            else
                MessageBox.Show("Enter more than 10 characters to Encrypt", "Encryptor");
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            string encryptedText;
            encryptedText = richTextBox2.Text;
            char[] allWords = encryptedText.ToCharArray();
            //char[] singleWords;
            string singleWord="";
            int length = allWords.Length - 1;
            int i, k=0, charByadd=0, check=0;
            for (i=k ; i < allWords.Length; i++)
            {               
                    
                    singleWord += allWords[charByadd].ToString();
                    charByadd++;
                check = singleWord.Length;
                    if (check == 10)
                    {
                        decrypter(singleWord);
                        singleWord = "";
                    }                                         
            }
            MessageBox.Show("Your message has been Decrypted", "Encryptor");
        }

        private void decrypter(string alphabet)
        {
            switch(alphabet)
            {
                case "ABBOTSHIPS":
                    richTextBox1.Text += " "; 
                    break;
                case "ARCHICARPS":
                    richTextBox1.Text += "\n";
                    break;
                case "ARCHRIVALS":
                    richTextBox1.Text += "\r";
                    break;
                case "ARCUATIONS":
                    richTextBox1.Text += "\t";
                    break;                
                case "ABCOULOMBS": 
                    richTextBox1.Text += "a"; 
                    break;
                case "ABDOMINALS":
                    richTextBox1.Text += "b"; 
                    break;
                    case "ABROGATORS":
                    richTextBox1.Text += "c"; 
                    break;
                    case "ABSOLVENTS":
                    richTextBox1.Text += "d"; 
                    break;
                    case "ACCEDENCES":
                    richTextBox1.Text += "e"; 
                    break;
                    case "ACCOLADING":
                    richTextBox1.Text += "f"; 
                    break;
                    case "ACETIFIERS":
                    richTextBox1.Text += "g"; 
                    break;
                    case "ACROSPIRES":
                    richTextBox1.Text += "h"; 
                    break;
                    case "ACUMINATED":
                    richTextBox1.Text += "i"; 
                    break;
                    case "ACUMINATES":
                    richTextBox1.Text += "j"; 
                    break;
                    case "ADDRESSORS":
                    richTextBox1.Text += "k"; 
                    break;
                    case "ADEMPTIONS":
                    richTextBox1.Text += "l"; 
                    break;
                    case "ADIPOCERES":
                    richTextBox1.Text += "m"; 
                    break;
                    case "ADJACENCES":
                    richTextBox1.Text += "n"; 
                    break;
                    case "ADMONITORS":
                    richTextBox1.Text += "o"; 
                    break;
                    case "ADRENALINS":
                    richTextBox1.Text += "p"; 
                    break;
                    case "AEROPAUSES":
                    richTextBox1.Text += "q"; 
                    break;
                    case "AEROPHOBES":
                    richTextBox1.Text += "r"; 
                    break;
                    case "AEROPHORES":
                    richTextBox1.Text += "s"; 
                    break;
                    case "AEROPHYTES":
                    richTextBox1.Text += "t"; 
                    break;
                    case "AEROPULSES":
                    richTextBox1.Text += "u"; 
                    break;
                    case "AEROSCOPES":
                    richTextBox1.Text += "v"; 
                    break;
                    case "AESTHESIAS":
                    richTextBox1.Text += "w"; 
                    break;
                case "AFFIRMANTS":
                    richTextBox1.Text += "x"; 
                    break;
                case "AFFIXTURES":
                    richTextBox1.Text += "y"; 
                    break;
                case "AFFLICTERS":
                    richTextBox1.Text += "z"; 
                    break;



                case "AFFRICATED":
                    richTextBox1.Text += "A";
                    break;
                    case "AFTERDAMPS":
                    richTextBox1.Text += "B";
                    break;
                    case "AFTERLIFES":
                    richTextBox1.Text += "C";
                    break;
                    case "AFTERPAINS":
                    richTextBox1.Text += "D";
                    break;
                    case "AGALACTIAS":
                    richTextBox1.Text += "E";
                    break;
                    case "AGATEWARES":
                    richTextBox1.Text += "F";
                    break;
                    case "AIRSTRIKES":
                    richTextBox1.Text += "G";
                    break;
                    case "ALBERTITES":
                    richTextBox1.Text += "H";
                    break;
                    case "ALBUTEROLS":
                    richTextBox1.Text += "I";
                    break;
                    case "ALFILERIAS":
                    richTextBox1.Text += "J";
                    break;
                    case "ALGARROBOS":
                    richTextBox1.Text += "K";
                    break;
                    case "ALGOMETERS":
                    richTextBox1.Text += "L";
                    break;
                    case "ALIZARINES":
                    richTextBox1.Text += "M";
                    break;
                    case "ALKALIZERS":
                    richTextBox1.Text += "N";
                    break;
                    case "ALLANTOIDS":
                    richTextBox1.Text += "O";
                    break;
                    case "ALLEGIANTS":
                    richTextBox1.Text += "P";
                    break;
                    case "ALLEVIANTS":
                    richTextBox1.Text += "Q";
                    break;
                    case "ALLOPLASMS":
                    richTextBox1.Text += "R";
                    break;
                    case "ALLOWABLES":
                    richTextBox1.Text += "S";
                    break;
                    case "ALTERITIES":
                    richTextBox1.Text += "T";
                    break;
                    case "ALTERNANTS":
                    richTextBox1.Text += "U";
                    break;
                    case "ALTIGRAPHS":
                    richTextBox1.Text += "V";
                    break;
                    case "ALUMSTONES":
                    richTextBox1.Text += "W";
                    break;
                case "AMAZONIANS":
                    richTextBox1.Text += "X";
                    break;
                    case "AMBULATORS":
                    richTextBox1.Text += "Y";
                    break;
                    case "AMBULETTES":
                    richTextBox1.Text += "Z";
                    break;



                    case "AMORPHISMS":
                    richTextBox1.Text += "0";
                    break;
                    case "AMPUTATORS":
                    richTextBox1.Text += "1";
                    break;
                    case "AMSINCKIAS":
                    richTextBox1.Text += "2";
                    break;
                    case "ANAEROBIUM":
                    richTextBox1.Text += "3";
                    break;
                    case "ANALOGISMS":
                    richTextBox1.Text += "4";
                    break;
                    case "ANARTHRIAS":
                    richTextBox1.Text += "5";
                    break;
                    case "ANCHYLOSED":
                    richTextBox1.Text += "6";
                    break;
                    case "ANCHYLOSES":
                    richTextBox1.Text += "7";
                    break;
                    case "ANGOSTURAS":
                    richTextBox1.Text += "8";
                    break;
                    case "ANIMALISTS":
                    richTextBox1.Text += "9";
                    break;


                    case "ANIMATISMS":
                    richTextBox1.Text += "`";
                    break;
                    case "ANIMATISTS":
                    richTextBox1.Text += "~";
                    break;
                    case "ANOVULANTS":
                    richTextBox1.Text += "!";
                    break;
                    case "ANTALKALIS":
                    richTextBox1.Text += "@";
                    break;
                    case "ANTIBUSERS":
                    richTextBox1.Text += "#";
                    break;
                    case "ANTICHLORS":
                    richTextBox1.Text += "$";
                    break;
                    case "ANTIELITES":
                    richTextBox1.Text += "%";
                    break;
                    case "ANTILIFERS":
                    richTextBox1.Text += "^";
                    break;
                    case "ANTIMONYLS":
                    richTextBox1.Text += "&";
                    break;
                    case "ANTIMUSICS":
                    richTextBox1.Text += "*";
                    break;


                    case "ANTINUKERS":
                    richTextBox1.Text += "(";
                    break;
                    case "ANTIPASTOS":
                    richTextBox1.Text += ")";
                    break;
                    case "ANTIRADARS":
                    richTextBox1.Text += "-";
                    break;
                    case "ANTISHOCKS":
                    richTextBox1.Text += "_";
                    break;
                    case "ANTISTYLES":
                    richTextBox1.Text += "=";
                    break;
                    case "ANTITRADES":
                    richTextBox1.Text += "+";
                    break;
                    case "ANTITRAGUS":
                    richTextBox1.Text += "\\";
                    break;
                    case "ANTITUMORS":
                    richTextBox1.Text += "|";
                    break;
                    case "ANTIVENOMS":
                    richTextBox1.Text += ".";
                    break;
                    case "APATOSAURS":
                    richTextBox1.Text += "/";
                    break;


                     case "APHORIZERS":
                    richTextBox1.Text += ">";
                    break;
                    case "APHRODITES":
                    richTextBox1.Text += "<";
                    break;
                    case "APOCOPATED":
                    richTextBox1.Text += ",";
                    break;
                    case "APOCOPATES":
                    richTextBox1.Text += "{";
                    break;
                    case "APOSTILLES":
                    richTextBox1.Text += "}";
                    break;
                    case "APPALOOSAS":
                    richTextBox1.Text += "[";
                    break;
                    case "APPENDENTS":
                    richTextBox1.Text += "]";
                    break;
                    case "APPOINTERS":
                    richTextBox1.Text += ";";
                    break;
                    case "APPOINTORS":
                    richTextBox1.Text += ":";
                    break;
                    case "AQUAFARMED":
                    richTextBox1.Text += "\"";
                    break;


                    case "ARCHAIZERS":
                    richTextBox1.Text += "'";
                    break;
                default:
                    break;
            }



    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string converted = richTextBox2.Text;
            string reduced = converted.Replace("SA", "~");
            converted = reduced;

            reduced = converted.Replace("GA", "`");
            converted = reduced;

            reduced = converted.Replace("DA", "!`");
            converted = reduced;

            reduced = converted.Replace("MA", "@");
            converted = reduced;

            reduced = converted.Replace("EE", "#");
            converted = reduced;

            reduced = converted.Replace("ES", "$");
            converted = reduced;

            reduced = converted.Replace("ANTI", "%");
            converted = reduced;

            reduced = converted.Replace("AN", "^");
            converted = reduced;

            reduced = converted.Replace("AL", "&");
            converted = reduced;

            reduced = converted.Replace("AP", "*");
            converted = reduced;

            reduced = converted.Replace("NA", "(");
            converted = reduced;

            reduced = converted.Replace("AD", ")");
            converted = reduced;

            reduced = converted.Replace("AC", "_");
            converted = reduced;

            reduced = converted.Replace("PO", "-");
            converted = reduced;

            reduced = converted.Replace("OO", "+");
            converted = reduced;

            reduced = converted.Replace("ON", "=");
            converted = reduced;

            reduced = converted.Replace("AM", "{");
            converted = reduced;

            reduced = converted.Replace("AERO", "}");
            converted = reduced;

            reduced = converted.Replace("LS", "[");
            converted = reduced;


            reduced = converted.Replace("AFF", "]");
            converted = reduced;

            reduced = converted.Replace("CO", "|");
            converted = reduced;

            reduced = converted.Replace("CUM", "\\");
            converted = reduced;

            reduced = converted.Replace("CE", "\"");
            converted = reduced;

            reduced = converted.Replace("OR", ":");
            converted = reduced;

            reduced = converted.Replace("DE", ";");
            converted = reduced;

            reduced = converted.Replace("TE", "?");
            converted = reduced;

            reduced = converted.Replace("ERO", "/");
            converted = reduced;

            reduced = converted.Replace("NTI", ">");
            converted = reduced;
         
            reducedRichBox.Text = reduced;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            char[] num = richTextBox3.Text.ToCharArray();
            label1.Text = num.Length.ToString();
        }
    }
}
