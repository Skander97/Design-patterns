 ## Projet Gestionnaire de tâches
Ce projet est une application de console simple développée en utilisant le langage C# et le framework .NET. Il permet de gérer des tâches en utilisant différents modèles de conception (patterns) pour organiser et structurer le code.

###Fonctionnalités
L'application de gestion de tâches offre les fonctionnalités suivantes :

- Création de tâches individuelles : Vous pouvez créer des tâches en spécifiant leur nom, leur description et leur date limite.
- Ajout et suppression de tâches : Vous pouvez ajouter et supprimer des tâches dans le gestionnaire de tâches.
- Tâches composites : Vous pouvez créer des tâches composites, qui sont des tâches regroupant plusieurs sous-tâches. Vous pouvez ajouter des sous-tâches à une tâche composite et exécuter des opérations sur l'ensemble des sous-tâches.
- Adaptation de tâches externes : Vous pouvez adapter des tâches externes en utilisant le modèle d'adaptateur. Les données de la tâche externe sont adaptées pour être utilisées avec les fonctionnalités du gestionnaire de tâches.
- Observateur de tâches : Vous pouvez observer les mises à jour de tâches à l'aide du modèle d'observateur. Lorsqu'une tâche est mise à jour, l'observateur est notifié.
Modèles de conception utilisés
- Le projet utilise les modèles de conception suivants :

Builder (Constructeur) : Le modèle de conception Builder est utilisé pour créer des tâches à l'aide du TaskBuilder. Il permet de spécifier les détails d'une tâche de manière fluide et facilite la création d'objets complexes.
Schéma du modèle Builder
Composite (Composite) : Le modèle de conception Composite est utilisé pour gérer les tâches composites. Une tâche composite peut contenir plusieurs sous-tâches, et les opérations peuvent être exécutées à la fois sur la tâche composite et sur ses sous-tâches.
Schéma du modèle Composite
Adapter (Adaptateur) : Le modèle de conception Adapter est utilisé pour adapter les tâches externes au format attendu par le gestionnaire de tâches. L'adaptateur ExternalTaskAdapter permet d'adapter les données d'une tâche externe pour les utiliser comme une tâche interne.
Schéma du modèle Adapter
Observer (Observateur) : Le modèle de conception Observer est utilisé pour observer les mises à jour de tâches. L'observateur TaskObserver peut être notifié lorsqu'une tâche est mise à jour, ce qui permet d'effectuer des actions en réponse à ces mises à jour.
Schéma du modèle Observer
Comment exécuter le projet
Pour exécuter le projet, suivez les étapes suivantes :

Assurez-vous d'avoir le framework .NET installé sur votre machine.
Clonez ou téléchargez le projet sur votre ordinateur.
Ouvrez une console ou un terminal et accédez au répertoire du projet.
Exécutez la commande dotnet run pour lancer l'application.
Vous devriez voir les différentes actions et sorties s'afficher dans la console, démontrant les fonctionnalités du gestionnaire de tâches.

N'hésitez pas à explorer le code source pour plus de détails sur la mise en œuvre des fonctionnalités et des modèles de conception utilisés.

