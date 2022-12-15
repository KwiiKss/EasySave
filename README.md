# System Programming Project - A3 IT

## Programming a backup software called EasySave 2.0 / EasySave 3.0

Group 1 composed of Kévin LAURENT, Kilyion Romary, Hugo CORSO and Nicolas FOUQUE.



# 1a | UML Diagrams - Version 2.0

#### Sequence Diagram
![Sequence](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/f05d425f-3468-4bcc-a42e-e24ac300e84c/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20221125%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20221125T161450Z&X-Amz-Expires=86400&X-Amz-Signature=218537648a2f17960ede228a112be06812210d7dbb88c59b8eec667fb5bf88e9&X-Amz-SignedHeaders=host&response-content-disposition=filename%3D%22Untitled.png%22&x-id=GetObject)

The class diagram is a simulation of our application and the different possibilities it offers to the user when using it.
By starting the application, the user will arrive on a welcome menu with the choice to choose a language. Then we come to the main page, you can choose between 3 options. we see what will happen if you move a file. The user then redefines his save path and the application saves the user's item in the right place.
he validates the blow.
and we see the model displacement file.
To quit the application, click on the cross.

#### Class Diagram

![Class](https://user-images.githubusercontent.com/93579262/207011393-99c927bc-bf3d-4450-ac8d-036ae32fd88f.png)
The class diagram follow the model (MVVM), we decided that the main interface could only create a Local object which would launch functions allowing the establishment of the backups/deletes/creations in complete safety as proposed by C# .

#### Activity Diagram

![Activity](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/01eb167e-7fbe-4786-b94a-8050f508d5ba/Diagramme_Dactivit_Projet_2_Final_%282%29.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20221125%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20221125T162132Z&X-Amz-Expires=86400&X-Amz-Signature=e9bb9954c5173d42c06c10ea1f2fa200739e87244f551a8336a69c4f58fcc286&X-Amz-SignedHeaders=host&response-content-disposition=filename%3D%22Diagramme%2520D%27activit%25C3%25A9%2520Projet%25202%2520Final%2520%282%29.png%22&x-id=GetObject)

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

# 1b | UML Diagrams - Version 3.0

#### Sequence Diagram

![Diagramme de séquenceV3](https://user-images.githubusercontent.com/118260547/207660476-16d50f0b-eef2-4402-9af0-274ae31c7927.png)


#### Class Diagram

![Diagramme de Classe V3](https://user-images.githubusercontent.com/118260547/207660425-ffc643d6-93e5-4cb3-afdc-e179bf2f3493.png)


#### Activity Diagram

![Diagramme D'activité Projet 2 V3](https://user-images.githubusercontent.com/118260547/207660450-9596dcff-6445-4472-81a4-d88090f6eb32.png)


### Diagram use case
![use case V3](https://user-images.githubusercontent.com/93580066/207735119-f68ca911-950e-4a2f-ac40-5de792dce002.png)




***
# 2 | Users

## `Published versions` :

### Console version
* EasySave 1.0 - 25/11/2022 - https://github.com/KwiiKss/EasySave-1.0
* EasySave 1.1 - 15/12/2022 - https://github.com/KwiiKss/EasySave-1.0

### Graphic version
* EasySave 2.0 - 15/12/2022 - This repository
* EasySave 3.0 - 15/12/2022 - This repository

======

# EasySave :

![WelcomePage](https://user-images.githubusercontent.com/93579099/207647399-75adad24-8eb5-4c01-ba03-7036b19e6293.png)

#### Welcome to the Easy Save home page, you can now choose the language for your favorite application.

![MenuEN](https://user-images.githubusercontent.com/93579099/207647496-0a834fbe-6159-4240-95bd-42165aea23fe.png)

#### Then you arrive on the main menu of the application where you can choose 3 options. So first you have the options that will be important to you.

![OptionsEN](https://user-images.githubusercontent.com/93579099/207647555-98ee4d01-43cf-42a2-8761-c080c2a9d9a8.png)

#### On the options page, you can again change the language of your application by clicking on the desired flag.
#### You can also set the default path for the files and folders you want to move.
#### You can return to the main menu by pressing Menu.

![ShowSavesEN](https://user-images.githubusercontent.com/93579099/207647624-725947f4-184a-418b-9de5-75d31b368994.png)

#### By clicking from the menu on the Show saves button, you will access all your files and folders that you have defined in the default path. The back button allows you to return to the main menu.

![CreatesSavesEN](https://user-images.githubusercontent.com/93579099/207647706-2b2e70de-4a38-4773-882b-1ea60fc5cbb8.png)

#### By clicking on creates know you then access the choice of a file or folder move. Select based on what you want to do.

![MoveFileEN](https://user-images.githubusercontent.com/93579099/207647892-21998658-1686-469f-830c-509cda5e6748.png)

#### This page will allow you to choose the source path of your file then to select if you wish to encrypt it and finally you choose the destination path.
#### Click on validate and your file will be moved.

![MoveFolderEN](https://user-images.githubusercontent.com/93579099/207647925-2848b92a-d73e-47e4-b405-3c3e7752d4c2.png)

#### This page will allow you to choose the source path of your folder then to select if you wish to encrypt it and finally you choose the destination path.
#### Click on validate and your folder will be moved.
#### And don't forget, your calculator on prevents you from performing a file move.

### Thank you for choosing EasySave

`Contact us if needed: kevin.laurent@viacesi.fr`
