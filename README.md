# PizzaApp (Windows Forms – C#)

Une application Windows Forms développée en C# qui simule un système de commande de pizzas.  
L’objectif est de proposer une interface conviviale permettant à l’utilisateur de personnaliser sa pizza, de visualiser le récapitulatif de la commande et d’obtenir le prix total en temps réel.

---

## 📦 Fonctionnalités

- Personnalisation complète de la pizza :  
  - Taille (petite, moyenne, grande)  
  - Type de croûte (fine / épaisse)  
  - Garnitures variées (fromage supplémentaire, champignons, tomates, oignons, olives, poivrons, etc.)  
- Calcul dynamique du prix selon les choix de l’utilisateur  
- Interface graphique interactive avec mise à jour en temps réel  
- Récapitulatif de commande avec affichage du détail et du montant total  

---

## 🏗 Architecture & Conception

- Le projet adopte une architecture orientée objet autour de classes telles que `Pizza`, `Pate`, `Garniture`, `Commande`, etc.  
- Chaque classe est responsable de ses propres données et opérations, ce qui permet une structure modulaire, réutilisable et facile à maintenir.  
- L’interface Windows Forms interagit avec ces classes pour présenter les choix à l’utilisateur et afficher le résultat.

---

## 🛠 Installation & Exécution

1. Clone le dépôt :
   ```bash
   git clone https://github.com/JHAMDI1/pizza.git
