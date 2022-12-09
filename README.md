# System Programming Project - A3 IT

## Programming a backup software called EasySave 2.0

Group 1 composed of Kévin LAURENT, Kilyion Romary, Hugo CORSO and Nicolas FOUQUE.



# 1 | Diagrammes UML

#### Sequence Diagram
![Séquences](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/f05d425f-3468-4bcc-a42e-e24ac300e84c/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20221125%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20221125T161450Z&X-Amz-Expires=86400&X-Amz-Signature=218537648a2f17960ede228a112be06812210d7dbb88c59b8eec667fb5bf88e9&X-Amz-SignedHeaders=host&response-content-disposition=filename%3D%22Untitled.png%22&x-id=GetObject)

The class diagram is a simulation of our application and the different possibilities in it that are available to the user when using it.
By starting the application the user will arrive on a welcome menu with different choices, he will have the possibility to change the language and also see the "About us" section. Following this we come to the main functionality of the application, moving files and folders divided into 2 menu options. Thanks to this diagram, we see that the application will search in the local, external or network disk for what is requested and will return the existing one. The user then redefines his save path and the application saves the user's item in the right place.
To exit the application, simply return to the menu and then select the exit option and the application will close.

#### Class Diagram

![Classe](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/d04d1de0-3d65-4812-9cbe-7e139567fc7b/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20221125%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20221125T162128Z&X-Amz-Expires=86400&X-Amz-Signature=e806655588b4d2b0eb0a48b2a70d6680822e8badad02ffa35e2c75890a6e24c2&X-Amz-SignedHeaders=host&response-content-disposition=filename%3D%22Untitled.png%22&x-id=GetObject)

The class diagram follow the model (MVVM), we decided that the main interface could only create a Local object which would launch functions allowing the establishment of the backups/deletes/creations in complete safety as proposed by C# .

#### Activity Diagram

![Activité](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/01eb167e-7fbe-4786-b94a-8050f508d5ba/Diagramme_Dactivit_Projet_2_Final_%282%29.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20221125%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20221125T162132Z&X-Amz-Expires=86400&X-Amz-Signature=e9bb9954c5173d42c06c10ea1f2fa200739e87244f551a8336a69c4f58fcc286&X-Amz-SignedHeaders=host&response-content-disposition=filename%3D%22Diagramme%2520D%27activit%25C3%25A9%2520Projet%25202%2520Final%2520%282%29.png%22&x-id=GetObject)

Our activity diagram allows us to follow exactly the options, choices and chains of actions that will be performed during the execution of EasySave
It also allows us to see at a glance the different features implemented and how they work.

### Diagram use case

![Use Case](https://user-images.githubusercontent.com/93580066/204036895-2816ec8a-f39b-498b-aaa7-f4346605f201.png)

Our Use Case Diagram aims to model our backup system. Thanks to it we can see the different possible interactions between the user, the system and the application (here a console).

We can therefore see that our user first enters our system via the console and from this point he is given the possibility of performing five major actions with options that result from them.

- **Exit**, will allow you to exit the console.
- **Change language**, will allow the alternation between French and English.
- Regarding **Open folder**, **Create Folder** and **Search folder**. These are only steps before accessing the most important features which are: file backup, file movement, file creation.

Note also the presence of **include** and **extend**:

- The extend is present between **Create works files** and **Write logs** because the logs are created automatically when creating or moving a file.
- For the include we find it between the **files** and the **folders** because it is possible to create, move, add a folder but this does not necessarily imply the creation or the movement of a file .

***
# 2 | Users

## `Published versions` :

### Console version
* EasySave 1.0 - 25/11/2022 - https://github.com/KwiiKss/EasySave-1.0
* EasySave 1.1 - 15/12/2022

### Graphic version
* EasySave 2.0 - 15/12/2022
* EasySave 3.0 - 15/12/2022

======
#### Menu in console application :
![Capture d’écran 2022-11-25 223113](https://user-images.githubusercontent.com/93579099/204057176-23216e41-0e69-4a93-8698-d01007aaa20a.png)

The application launches and you arrive on the main menu. Thanks to this one you can change the language first or even see the credits of the application.

![image](https://user-images.githubusercontent.com/93579262/206675992-b996f5c1-cb11-41bf-b44d-7a99697d1fcd.png)

Following this, your going to encounter a page with 3 option,"creates saves","show saves","Options".

![image](https://user-images.githubusercontent.com/93579262/206676133-6059f12f-76e7-454a-918f-ddd57d842beb.png)

If you press "creates saves", the next page going to ask if you want to move a folder or a file.

![image](https://user-images.githubusercontent.com/93579262/206678374-ed2d500a-8949-4e2e-ae32-4c924c17f597.png)

chose a option:

![image](https://user-images.githubusercontent.com/93579262/206678452-d3aa02a5-f4e4-4e7f-a5aa-7c6cfdcb3f98.png)

![image](https://user-images.githubusercontent.com/93579262/206678504-458b4c27-8d26-4f01-86bd-00a8fa455821.png)


Folder that you can then move to any storage medium using the "Move your folder" menu option. The same goes for moving files by going to the "Move your file" option.
As soon as any file or folder is moved, you will have a single log file, which will be searchable in order to see at what time, what date and what file or folder was moved, etc.

In these different options, the same steps return the application will ask you for a file or folder name then its source and destination path depending on the action you want.

Once your work is finished, simply select the "Exit" option and finally the application will close at the next key press.


### Thank you for choosing EasySave

`Contact us if needed: kevin.laurent@viacesi.fr`
