#region variables 
string input;
int NombreGateau = 0;
(int x, int y) positionJoueur = (2, 16);
(int x, int y) positionTresor = (6, 14);
(int x, int y) positionTresor2 = (13, 8);
(int x, int y) positionTresor3 = (16, 8);
(int x, int y) positionTresor4 = (2, 16);
(int x, int y) positionBoss = (6, 16);
(int x, int y) positionBoss2 = (12, 14);
(int x, int y) positionSnitch = (11, 13);
(int x, int y) positionSnitch2 = (17, 13);
(int x, int y) positionSnitch3 = (11, 8);
(int x, int y) positionSnitch4 = (17, 4);
(int x, int y) positionSnitch5 = (18, 1);
(int x, int y) positionSorti = (2, 17);
(int x, int y) positionSorti2 = (19, 1);
(int x, int y)[] murs =
 
{
    (1,18),(2,18),(3,18),(4,18),(5,18),(6,18),(7,18),(8,18),(9,18),(10,18),(11,18),(12,18),(13,18),(14,18),(15,18),(16,18),(17,18),(18,18),(19,18),(20,18),
    (1,17),       (3,17),                                                                                                                          (20,17),
    (1,16),       (3,16),       (5,16),       (7,16),                         (12,16),        (14,16),(15,16),(16,16),(17,16),                     (20,16),
    (1,15),       (3,15),       (5,15),(6,15),(7,15),(8,15),  (10,15),(11,15),(12,15),        (14,15),     (16,14),(17,14),(18,14),                (20,15),
    (1,14),                     (5,14),                       (10,14),                        (14,14),                     (18,13),                (20,14),
    (1,13),(2,13),(3,13),(4,13),(5,13),                       (10,13),        (12,13),(13,13),(14,13),             (17,12),(18,12),                (20,13),
    (1,12),(2,12),                          (7,12),(8,12),(9,12),(10,12),(11,12),(12,12),                          (17,11),                        (20,12),
    (1,11),           (4,11),               (7,11),                           (12,11),(13,11),   (15,11),                                          (20,11),
    (1,10),     (3,10),(4,10),(5,10),(6,10),(7,10),  (9,10),                                     (15,10),                                          (20,10),
    (1,9),      (3,9),                               (9,9),             (12,9),(13,9),(14,9),(15,9),(16,9),(17,9),(18,9),                          (20,9),
    (1,8),      (3,8),      (5,8),(6,8),             (9,8),             (12,8),              (15,8),       (17,8),                                 (20,8),
    (1,7),      (3,7),            (6,7),       (8,7),(9,7),(10,7),(11,7),(12,7),             (15,7),       (17,7),                                 (20,7),
    (1,6),                        (6,6),       (8,6),                                        (15,6),       (17,6),                                 (20,6),
    (1,5),(2,5),      (4,5),      (6,5),       (8,5),(9,5),(10,5),      (12,5),(13,5),       (15,5),       (17,5),(18,5),                          (20,5),
    (1,4),(2,4),      (4,4),      (6,4),                                (12,4),              (15,4),              (18,4),                          (20,4),
    (1,3),            (4,3),      (6,3),(7,3),(8,3),(9,3),              (12,3),              (15,3),       (17,3),(18,3),                          (20,3),
    (1,2),            (4,2),                                            (12,2),       (14,2),(15,2),       (17,2),                                 (20,2),
    (1,1),(2,1),(3,1),(4,1),(5,1),(6,1),(7,1),(8,1),(9,1),(10,1),(11,1),(12,1),                                                                    (20,1),

};
(int x, int y)[] murs2 =
{
    (1,3),(2,3),(3,3),
    (1,2),
    (1,1),(2,1),(3,1),
};
#endregion
#region Intro
Console.WriteLine("Vous etes au bureau et vous voulez partir en pause 15 minutes en avance, mais les snitch et les boss peuvent vous voir faites attention dans le labyrinthe du capitalisme");
Console.WriteLine("\n"); // \n (saut a la ligne)

#endregion
#region game loop
while (true)
{
    Console.WriteLine($"Vous etes a la position {positionJoueur}");
    Console.WriteLine($"Vous avez: {NombreGateau} Snack");
    Console.WriteLine("\n"); // \n (saut a la ligne)
    Console.Write(" -> ");
    input = Console.ReadLine();
    //Rendermurs();

    //deplacement 

    if (input == "nord")
    {
        //positionJoueur.y = positionJoueur.y + 1;
        if (EstUnMurs((positionJoueur.x, positionJoueur.y + 1)))
        {
            Console.WriteLine("Impossible il y a un bureau en face");
        }
        else
        {
            positionJoueur.y = positionJoueur.y + 1;
        }

    }
    if (input == "sud")
    {
        if (EstUnMurs((positionJoueur.y, positionJoueur.y -1)))
        {
            Console.WriteLine("Impossible il y une salle en face");
        }
        else
        {
            positionJoueur.y = positionJoueur.y -1;
        }

    }
    if (input == "est")
    {        
        if(EstUnMurs((positionJoueur.x +1 , positionJoueur.y )))
        {
            Console.WriteLine("Impossible il a la fontaine a eau");
        }
        else
        {
            positionJoueur.x = positionJoueur.x + 1;
        }
    }

    if (input == "ouest")
    {
        if (EstUnMurs((positionJoueur.x - 1, positionJoueur.y)))
        {
            Console.WriteLine("Impossible il a le ventilateur");
        }
        else
        {
            positionJoueur.x = positionJoueur.x - 1;
        }
    }
    if(positionJoueur == positionSorti)
    {
        Console.WriteLine("Important de se reposer apres avoir rien fait");
    }
    

    if (positionJoueur == positionSorti2)
    {
        Console.WriteLine("Important de se reposer apres avoir rien fait");
    }

    if(positionJoueur == positionTresor)
    {
        NombreGateau++;
        Console.WriteLine("T'as trouver les granola d'une balance");
        Console.WriteLine("\n"); // \n (saut a la ligne)
    }

    if (positionJoueur == positionTresor2)
    {
        NombreGateau++; 
        Console.WriteLine("T'as trouver les gateaux de ton ennemi");
        Console.WriteLine("\n"); // \n (saut a la ligne)
    }

    if (positionJoueur == positionTresor3)
    {
        NombreGateau++;
        Console.WriteLine("T'as trouver les chocolats du CEO");
        Console.WriteLine("\n"); // \n (saut a la ligne)
    }

    if (positionJoueur == positionTresor4)
    {
        NombreGateau++;
        Console.WriteLine("T'as trouver les chocolats du CEO");
        Console.WriteLine("\n"); // \n (saut a la ligne)
    }

    if (positionJoueur == positionSorti)
    {
        if (NombreGateau == 1)
        { Console.WriteLine("Jeune ninja tu peux mieux FAIRE"); }
    }

    if (positionJoueur == positionSorti)
    {
        if (NombreGateau == 2) 
        Console.WriteLine("Ton sensei est FIERE de toi ");
    }

    if (positionJoueur == positionSorti)
    {
        if (NombreGateau == 3) 
        Console.WriteLine("Le Ninja du Capitalisme se repose apres avoir rien fait, FELICITATION");
        break;
    }

    if(positionJoueur == positionBoss)
    { Console.WriteLine("Tu t'est fait griller par le PDG t'es virer"); }

    if (positionJoueur == positionBoss2)
    { Console.WriteLine("Tu t'est fait griller par le CEO t'es virer"); }

}
#endregion
#region declaration
void Rendermurs()
{
    Console.Clear();
    if (EstUnMurs((20, 1)))
    {
        Console.Write("█ ");
    }
    else
    {
        Console.Write(" ");
    }
}
bool EstUnMurs((int x, int y)Position)
{
    for (int i = 0; i < murs.Length; i++)
    {
        if (murs[i] == Position)
        {
            return true;    

        }
    }
    return false;
}

#endregion
#region Start
Console.WriteLine();
#endregion