# WEB452_ASP.NET_0835715_Assignments
# Date:2023-10-04
# Time:0603

Started the Project with the fresh mind set bring back the memories from the C# assignment nowlets start the assignment firstly we will see the requiermenets and the assignment details. it say we have to create the MVC application with some functionalities and Some added pages.

So we will start our project with the Creating the MVC application on the With our Product name Which :"Tie" And Named the file:- "Aditya_Tie"

So the Application is created and we will Firstly changing the Welcome message to the Product Tie 

And i also become Familiar with the whole interface and becoming familar with all files taking my time tounderstand all files and examining the files and after this we will start the Parts that was provided by the Andrew in the content folder for us. As far as i understaand the Project there is the basicly we have to create the database table as we created in the class afterwards there are few changes that we will do according to requierement. 

Time 0932
## Part 2 Adding Controller 
Started the Part 2 As the part one Was just creating the MVC application 
So, in the second part of my project, I added something pretty important - a controller called `HelloWorldController.cs`. I basically followed the step-by-step instructions from the website to make this happen. It wasn't too hard, and the best part is, it worked!

After I did what the website said, I got the same output as the picture they showed. It was a pretty cool feeling to see my project working just as I wanted it to. So, Part 2 is done and dusted!

I'm excited to see what's next, but Part 3 is going to be about the `Movie.cs` file, which might be a bit trickier. Stay tuned for more updates!

Lets take a little break and we will start with the part 3
Time : 1223
## Part 3: Adding a View

Alright, here we are in Part 3, and things are getting interesting. Today, I added a new file called `Index.cshtml` in the `View/HelloWorld` folder. It's a crucial part of giving my project a user interface.

I followed the instructions to create this `Index.cshtml` file, and I even tested it - it's working like a charm. It's always a relief when things go smoothly in coding, right?

But that's not all! I also made some changes to the `Views/Shared/_Layout.cshtml` file. I added our company name, "Fashion Tie," to the title. It's as simple as tweaking the title tag, and now my project looks more professional with our company's name up there.

Time : 1508

Inside the `Index.cshtml`, I changed the title to "FashionTie" and added a heading that says "Tie List." Everything looks just perfect, and the output is spot on. It's always satisfying to see your changes take effect.

So, in Part 3, I've not only added a view but also made my project look more polished and branded with our company's name. It's shaping up nicely, and I can't wait to see what's next!

Finally its Just a Start of the Assignment i am feeling like its too much mannn 
no problem we will go one step at time one goal at time which is completeing all the part sucessfully without any error 
now we will go to the Part 4 which i think is the Movie.cs File thing that i am scared of lets see what happens.......

So i thought i will dothe assignment in one day but i dont think so its gonna happpen 1-2 days its right now 
Time : 2209
And i am Tierd of the all day we will cuntionue this work tommorow thank you peace out

Date : 2023-10-05
Time 1234

## Part 4 Add a Model Class 

See this the one now we will Add Movie.cs Means We will Add the Tie.Cs file in the Model Folder and we will create the Characterstics according to the tie Product minimum should be 6 its done we add id , product name , material and its avaviable or not just likethis in the Public class Tie.

We Will perfome now the NUGET package From PMC Console Posted the Code
#### Install-Package Microsoft.EntityFrameworkCore.SqlServer With Vesrion 3.1.12

Now Similar We Will create a NEw File name in The Data Folder Which e=we WIll Create From the Scratch Abnd replace the Code Carefull withmy names and Namspacenot the movie and i definetliy think this movie and tie will create an error in my application, but i hope it should not create this kind of error 
now 
using Aditya_Tie.Data;
using Microsoft.EntityFrameworkCore;
Add this think 
After thus configuered the databasse 
 
     options.UseSqlServer(Configuration.GetConnectionString("TieContext")));

Time: 0456
Scaffold pages

Add Controller dialog:

Model class: Tie (Tie.Models)
Data context class: TieContext (Tie.Data)
