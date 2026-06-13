# Platformer 2D — Unity

> Projet réalisé dans le cadre du module **Développement Avancé** à l'IUT d'Orsay.

---

## Description

Jeu de plateforme 2D développé avec Unity, inspiré du style Mario.

Le joueur doit traverser deux niveaux en évitant les ennemis, les pics et l'eau, tout en récupérant des pièces et des points de vie afin d'atteindre la sortie.

Le premier niveau a été conçu comme le niveau principal du jeu. Il permet de découvrir et d'utiliser l'ensemble des mécaniques demandées dans les tutoriels : déplacement, saut, escalade d'échelles, ennemis, pics, eau, collecte de pièces et de points de vie.

Le second niveau est volontairement plus court. Son objectif est de permettre au joueur d'accéder rapidement à la fin de partie afin de démontrer l'ensemble de la boucle de jeu : changement de niveau, conservation des vies et du score, écran de victoire et retour au menu principal.

Ce choix a été fait afin de faciliter la démonstration et la validation de toutes les fonctionnalités demandées dans les tutoriels.

---

## Fonctionnalités implémentées

| Catégorie | Fonctionnalités |
|---|---|
| **Joueur** | Déplacement, saut, escalade d'échelles |
| **Animations** | Idle, Run, Climb, Death |
| **Caméra** | Caméra dynamique avec Cinemachine (State-Driven) |
| **Obstacles** | Ennemis, pics, eau |
| **Collectibles** | Pièces, points de vie |
| **Interface** | Score, HUD (vies), menu principal, menu pause |
| **Scènes** | Deux niveaux, écran de victoire, écran Game Over |
| **Audio** | Effets sonores, musique de fond |

---

## Contrôles

| Touche | Action |
|---|---|
| `←` / `→` | Déplacement |
| `↑` / `↓` | Monter/descendre une échelle |
| `Espace` | Saut |
| `Échap` | Pause |

---

## Organisation des niveaux

### Niveau 1

Niveau principal du jeu.

Fonctionnalités présentes : déplacement, saut, escalade d'échelles, ennemis, pics, eau, pièces, points de vie, sortie de niveau.

### Niveau 2

Niveau plus court permettant de terminer rapidement la partie.

Fonctionnalités présentes : ennemis, pièces, points de vie, sortie vers l'écran de victoire.

---

## Boucle de jeu

```
Menu principal → Niveau 1 → Niveau 2 → Écran de victoire → Menu principal
```

En cas de perte de toutes les vies :

```
Niveau en cours → Écran Game Over → Menu principal
```

---

## Build

Le build du jeu se trouve dans le dossier :

```
Release/
```

---

## Technologies utilisées

- **Unity** (Universal 2D)
- **C#**
- **Cinemachine** — caméra dynamique
- **TextMeshPro** — interface utilisateur
- **Unity Input System** — gestion des entrées
- **Assets** : [Kenney.nl — New Platformer Pack](https://kenney.nl/assets/new-platformer-pack) (licence CC0)

---

## Structure du projet

```
Assets/
├── Animations/
│   ├── Player/
│   ├── Pickups/
│   └── Enemy/
├── Audio/
│   └── Music/
├── Input System/
├── Materials/
├── Prefabs/
├── Scenes/
├── Scripts/
├── Sprites/
└── Tiles/
    ├── Background/
    └── Platforms/
```

---

## Fonctionnalités bonus

- HUD amélioré avec des icônes pour les vies, le score et la clé récupérée.
- Chronomètre global affiché pendant la partie et reporté sur l'écran de victoire.
- Ajout d'une clé dans le niveau 2 avec indicateur visuel dans le HUD.
- Porte de sortie verrouillée dans le niveau 2 nécessitant la récupération de la clé avant de pouvoir terminer le jeu.

---

## Auteur

Mohamed Jadid — BUT Informatique, Groupe 6B-1, IUT d'Orsay