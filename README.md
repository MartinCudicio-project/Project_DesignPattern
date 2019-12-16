Monopoly_game

Nos design pattern sont :

1)singleton pour la classe game pck elle est unique forcement

2)Command pattern : chaque action (on les mettra toutes dans la classe game ou on cree une classe pour une action) doit suivre le modèle suivant
 class function()
{ 
  void apply()
  bool isLegal() 
}

3)MVC : Dans notre cas, la (view) est donc le Menu
            le (model) est notre list de Box
            le (controller) est composé par BoxInvoker BoxCommand, etc...

