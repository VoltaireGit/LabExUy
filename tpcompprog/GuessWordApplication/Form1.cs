using System.Collections;
using System.Text;
namespace GuessWordApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand;
        String[] words = {
            "royal",
            "coke",
            "soda",
            "sting",
            "cobra",
            "apple",
            "mountaindew",

        };

        String word;
        int word_order;

        public void load_word()
        {
            if (word_order < words.Length)
            {
                word = words[word_order].ToUpper();

                int word_length = word.Length;

                StringBuilder maskedWord = new StringBuilder(word_length);

                int masks = word_length / 2;

                ArrayList letter_masks = new ArrayList();
                for (int i = 0; i < masks; i++)
                {
                    bool can_loop = true;
                    do
                    {
                        int rand_num = rand.Next(word_length);
                        if (!letter_masks.Contains(rand_num))
                        {
                            letter_masks.Add(rand_num);
                            can_loop = false;
                        }
                    } while (can_loop);
                }

                for (int i = 0; i < word.Length; i++)
                {
                    if (letter_masks.Contains(i))
                    {
                        maskedWord.Append("?");
                    }
                    else
                    {
                        maskedWord.Append(word[i]);
                    }
                }
            

                lb_mask_word.Text = maskedWord.ToString();
            }
            else
            {
                refresh_words();
                load_word();
            }
        }

        public void refresh_words()
        {
            words = words.OrderBy(x => rand.Next()).ToArray();

            word_order = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random();

            refresh_words();
            load_word();
        }
        private void tb_guess_Click(object sender, EventArgs e)
        {
            if (tb_guess.Text.Equals("Play Again?"))
            {
                word_order++;
                load_word();
                tb_guess.Text = "Guess";
                wrong_guessed_list.Items.Clear();

            }

            if (!tb_answer.Text.Equals(""))
            {
                if (tb_answer.Text.ToUpper().Equals(word))
                {
                    lb_mask_word.Text = word;
                    tb_guess.Text = "Play Again?";

                    MessageBox.Show("Correct Guess");
                }
                else
                {
                    wrong_guessed_list.Items.Add(tb_answer.Text);

                    MessageBox.Show("Wrong Guess");
                }

                tb_answer.Text = "";
            }
        }
   
    }
}
