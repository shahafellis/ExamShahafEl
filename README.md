# ExamShahafEl
1. What is the newer platform for windows forms in .NET ?
2. What is the advantages of winform over other platforms?
3. What are the problems with a single drawing worker?
4.To solve the problem of a single worker we add another verb to help him with the other actions and send them to him
5. How do you create new workers? Give example
6. How do we ask the drawing worker to perform a drawing task for us?
7. Where and how do we print debug messages in winform (since there is no console)
8. What is the difference between Properties and Events?
9. What’s the difference between listbox and combo box?
10. How can we add an open-file-dialog to our project? also demonstrate in code
11. How can we add a menu to our project? also demonstrate in code
12. Create a Message box with a yes , no buttons, and an Error icon
13. What’s the difference between checkbox and radio button?
14. What the purpose of the designer.cs file?
15. Does winform also has static void main ? if so, what is its purpose?
16. Why is it important to give names to our components?
17. How do we mark a resource (i.e. photo) to be copied to the runtime folder?
18. What is a Timer? When can we use it? also demonstrate in code
19. How do we make a variable become global to our form?
20. What is the purpose of const variables? Give an example?
21. In the Keydown event, how can we detect which key was pressed?

Answers : 
1) in December 4, 2018, Microsoft announced releasing Windows Forms as an open source project on GitHub. It is released under the MIT License. With this release, 
Windows Forms has become available for projects targeting the .NET Core framework. However, the framework is still available only on the Windows platform,
 and Mono's incomplete implementation of WinForms remains the only cross-platform implementation.


2)The advantages of windorms over other platforms is : 
1) There's greater support in the 3rd-party control space for WinForms. (That's changing, but for now by advantage of time, WinForms has greater support in the community.)
2)The Mono have support for winforms in cross-platform (e.g., it work on Linux and Mac) .


3)The problem of a single worker is that he can't perform a sleep operation and all kinds of different actions ... and at the same time draw.


4)To solve the problem of a single worker we add another worker to help him with the other actions and send them to him.


5) 
              Task.run(
		
		  () =>
               		 {
               	   
                   
 
                      		  Action action = () => { numLbl.Text = i.ToString(); };

                      
                      		  numLbl.BeginInvoke(action);

                      		  Thread.Sleep(500);
                    
              		  });


6) Action action = () => {};
	 
	TheNameOfLblOrTxt.BeginInvoke(action);


7)where can you see the Debag : Debug => windows => out put you can see the Debuging.
  how you print debug you write code : system.diagnostics.Debug in your code or top of the code  where the using system and write there , then in your code you can write debug.wirteline : ( "What do you want to see when the action works");


8)The differences between Properties and Events are as follows: In Properties you can change the settings of the element (element name, element text, size, shape), 
at events you choose what you want to happen as soon as you click on the element or extract a specific key For an element you are actually creating an event for the element.


9)The difference between combo box and listbox is that combo box you put in amount of components but of all components you can choose only one component however in listbox this list of components is good to use to create an array.


10)We have tools aside where openfiledialog appears, you just drag it to the mainform where you want to open the file.
   OpenFileDialog ofd = "image files(*.jpg)| *.jpg";


11)We have tools aside where menudialog appears, you just drag it to the mainform where you want to open the file , 
  Once you open the menu you choose what to write in it if you want to create a function in what you have registered within the menu you press 2 clicks and within the function you enter the code.
	
	And within the function you write  dialogresult options = Whatever you want to happen;

12)   DialogResult DialogResult = MessageBox.Show("yes , no , Error", MessageBoxButtons.YesNo , MessageBoxIcon.Error);








13) In check box you mark all kinds of things you want to check a student coming or not, did I buy this product or not, yes I mark if not
  And in radio box you are actually activating a particular component that you run off that it activates when you click.




14) The meaning of designer.cs is that within designer.cs you can change all kinds of settings like size, shape, color, add or remove.


15) yes winform has static void main its purpose to entry point of the app.


16)It is important to name the components because during the code we will want to use these components, as soon as we call the component in its action we can easily find it,
 we give names because within a long code there are lots of components.


17) copy to output directory and then you can chose copy if newer or copy always.


18)timer is a clock that runs according to the time we set, you can use the timer in the code while we want to run a command at a specific time or event.
	private void timer1_Tick(object sender, EventArgs e)
        {
            _timer++;
            this.Text = _timer.ToString();
            
            if (_timer == 10)
            {
                this.Text = "done";
                timer1.Stop();
            }



19) you can make variable come global when you put the variable under the public partial class.


20) The meaning of const that you can put in a value that cannot be changed during the code, if you want to change the predetermined value you can easily change it at the top of the code, then the figure changed throughout the code.
    const in START_MONEY = 1000;

21)e.KeyCode == Keys.Enter
