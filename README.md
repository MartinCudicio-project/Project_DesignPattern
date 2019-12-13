Monopoly_game

Design pattern : singleton pour la classe game pck elle est unique forcement
Command pattern : chaque action (on les mettra toutes dans la classe game ou on cree une classe pour une action) doit suivre le modèle suivant
 class function()
{ void apply()
  bool isLegal() 
} 
Je suis pas encore mais ça a l'air mieux de faire une classe par fonction, avec apply et isLegal le test pour voir si c'est possible

Le dernier pattern peut-etre :
le MVC : ou on cree un affichage (view) et ou la classe game est le controller // vraiment pas mal est validé par le prof vu qu'en plus ya tjrs pas d'affichage
sinon 
Deccrator : donner des nouvelles foctionnalités à un objet (user,case) genre pour pouvoir acheter maison ou autre
J'ai pensé au state pattern mais grosse flemme de faire par état et tout faut tous repenser
Et sinon strategy pattern mais en mode bullshit un peu dans le sens ou on choisis bien des algorithm pendant le runintime, mais je sais pas comment implementer ça de manière vraiment bien

En gros faire le mvc, si un autre truc te aprle dit moi
