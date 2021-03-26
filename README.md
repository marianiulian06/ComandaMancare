



Panel Umbraco: 

email: miloiu_marian@yahoo.com
password: marianiulian



Pentru: *Formular HtmlForm -- UmbracoBeginForm
- ContactSugestiiClientiForm;

1. Creare ContactSugestiiClienti template
2. Creare ContactSugestiiClienti document type
3. Creare Model 
4. Creare Controler unde vom avea metodele de redare si de trimitere a 
formularului 
5. Creare partialview pentru Form
6. Adauga ContactSugestiiClienti form la template
7. Creare pagina ContactSugestiiClienti in panel Umbraco


Pentru: *Comunicarea view-urilor
Am implementat similar ca si la UmbracoBeginForm, pana la partea de trimitere a formularului. 
Am instalat fisierele Ajax. In controller am returnat trimiterea formularului catre una din cele doua view-uri( _FormSucces.cshtml sau _FormError.cshtml).
Puteam folosi acelasi model ca si la UmbracoBeginForm dar am mai creat unul cu nume specific pentru a nu se confunda 
(presupunand ca modele erau diferite si aveau alte atribute).



Pentru: *Umbraco ApiController
- MyApiController: Am creat un endpoint pentru care am vrut ca oricand este 
apelat sa afiseze cate un Nume random dintr un array. Am creat model,am folosit 
Get si Post. Am incercat sa fac Attribute Routing, ca sa il activez am creat o 
Componenta si am inregistrat aceasta folosind un Composer (not complete yet). 

Pentru: Variabile de sesiune *TempData / *Session 
-am implementat TempData in UmbracoBeginForm si Session in SignInSurface.

