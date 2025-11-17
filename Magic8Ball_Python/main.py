"""
Magic 8Ball App
This project is a simulated magic 8ball that uses random choice from a collection of predictions
to predict the future.

Author: Matthew Holyk

Created: Nov 17, 2025
"""
import random

# a collection of predictions to answer the user
PREDICTION_TUPLE = ("It is certain",
                   "It is decidedly so",
                   "Without a doubt",
                   "Yes definitely",
                   "You may rely on it",
                   "As I see it, yes",
                   "Most likely",
                   "Outlook good",
                   "Yes",
                   "Signs point to yes ",
                   "Don't count on it",
                   "My reply is no",
                   "My sources say no",
                   "Outlook not so good",
                   "Very doubtful ",
                   "Reply hazy, try again",
                   "Ask again later",
                   "Better not tell you now",
                   "Cannot predict now",
                   "Concentrate and ask again " )


def get_question():
    """
    Prompt the user for the question they want answered.
    User input progresses the program but the input is not used.
    :return: none
    """
    input("What is your question for the Magical 8Ball? ")

def ask_again():
    """
    Prompt the user whether they would like to continue the program and ask another question.
    :return: boolean response from user
    """
    return input("Would you like to ask the Magic 8Ball another question? [Y/N] ").strip().upper() == "Y"

def main():
    another = True  # boolean value to repeat the program or not

    print("Hello user! ", end='')
    while another:
        # Prompt the user for the question they want answered.
        get_question()
        # Print the answer to the user question.
        print(f"The Magic 8Ball predicts: {random.choice(PREDICTION_TUPLE)}")
        # Prompt the user whether they would like to continue the program and ask another question.
        another = ask_again()
    print("Goodbye user. Have a wonderful future.")

if __name__ == '__main__':
    main()