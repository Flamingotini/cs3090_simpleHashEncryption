# cs3090_simpleHashEncryption

TITLE: 
Secret Message (Dis)Combobulator

WHAT THIS PROGRAM DOES:
The Secret Message (Dis)Combobulator is a very simple C# encoder program that lets
you trade secret messages with your friends. You can create secret messages by
entering in the phrase you want to encrypt along with a secret password. The 
program will spit out a string of random numbers. Give these numbers and the
password to your friend. They can then easily decrypt the message by entering
them into the (Dis)Combobulator.

HOW TO RUN THIS PROGRAM:
Secret Message (Dis)Combobulator can be run in Visual Studio and just
uses the Console. 
1. Open Visual Studio
2. Select "Clone a repository"
3. Paste "https://github.com/Flamingotini/cs3090_simpleHashEncryption.git" into the
   repository location.
4. Select a path on your drive where you would like to store this project.
5. Click "Clone"
6. Run the program by going to Debug > Start Debugging 
	OR hit F5 
	OR Click the solid green arrow next to SimpleHashEncryptionTool
7. Be patient. Eventually your machine's console window will pop up and you can start 
   encoding and decoding your secret messages right away.

WARNINGS:
This tool is for educational purposes only. It is not meant to safeguard
any sensitive data. The algorithm is too simple and easy crack if the 
encoded message and password were to ever fall into the wrong hands. Only
use this for fun, like passing secret notes with your friend in class. 

ETHICAL CONSIDERATIONS AND RESPONSIBLE USE:
This tool could give users a false sense of security that their encoded messages
are safe and secure from prying eyes. Most people may disregard a random string of numbers
and periods, but anybody with a strong desire and a little cryptography knowledge
could demistify this algorithm quickly, especially if they already had the password cypher. 

There is also no content controls in this tool. It will encode any type of string
given to it, including but not limited to: harmful or threatening messages; illicit 
and/or illegal URLs; and any other questionable content that can be put in string form.
Users should never copy and paste unknown URLs into their browser unless they come
from a trusted source.  