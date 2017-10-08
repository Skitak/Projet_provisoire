using System;
using System.Collections.Generic;

public static class DialogueList
{
	private static Dictionary<String, String> _lines = new Dictionary<String, String>{
		{"0.0.0.0", "Anomalie Smith, 34 ans, télékinésiste. C'est bien vous ?"},
		{"0.0.1.0", "Oui"},
		{"0.1.0.0","Savez-vous pourquoi nous sommmes ici ?"},
		{"0.1.1.0", "Non, et vous ?"},
		{"0.1.1.1","Aucune idée"},
		{"0.1.1.2", "Euuh... Oui je crois"},
		{"0.1.1.3", "Pour parler du bon vieux temps."},
		{"0.2.0.0", "Nous sommes ici pour vous trouver une place dans notre société de paix, débarassée des derniers super-vilains. Répondez simplement à mes questions. Vous comprenez ?"},
		{"0.2.1.0", "Compris"},
		{"0.2.1.1", "Mhmh"},
		{"0.3.0.0", "Tout d'abord, dîtes m'en plus sur votre pouvoir. Nous trouverons peut être un moyen de le rendre utile."},
		{"0.3.1.0", "Laissez moi vous expliquer..."},
		//level initialisation

		{"1.0.0.0", "Bien. Commencons l'entretien."},
		{"1.0.1.0", "OK"},
		{"1.1.0.0", "Comment vous sentez-vous, monsieur Smith ?"},
		{"1.1.1.0", "Très bien ! Vous savez mettre les gens à l'aise..."},
		{"1.1.1.1", "Ça va... je crois"},
		{"1..1.2", "À vrai dire, je vous trouve plutôt inquiétant"},
		{"1.1.1.3", "Qu'est ce que ça peut vous faire ?"},
		{"1.2.0.0", "Quelles sont vos ambitions actuelles ?"},
		{"1.2.1.0", "Je cherche juste du travail"},
		{"1.2.1.1", "Je veux sauver des vies. C'est ce que je fais de mieux"},
		{"1.2.1.2", "Je souhaite devenir riche et célèbre"},
		{"1.3.0.0", "Seriez vous capable de sauver des citoyens bloqués dans un immeuble suite à un séisme ?"},
		{"1.3.1.0", "J'ai déjà eu l'occasion de le faire..."},
		//level 2

		{"2.0.0.0", "Monsieur Smith, vous m'écoutez toujours ?"},
		{"2.0.1.0", "Oui oui."},
		//Stylo

		{"3.0.0.0", "Ne m'en voulez pas, je voulais juste tester vos réflexes."},
		{"3.0.1.0", "Pas de soucis, je comprends"},
		{"3.0.1.1", "Mais vous êtes complètement cinglé !"},
		{"3.1.0.0", "J'aimerai également vérifier vos capacités de raisonnement. Voici une suite de carte. Essayez de la compléter"},
		{"3.1.1.0", "Faites moi voir ça"},
		//cardScene

		{"4.0.0.0", "Supposons maintenant qu'une menace ait détruit la ville. Une anomalie et un citoyen sont sur le point de mourir et vous ne pouvez en sauver qu'un seul. Lequel choisissez-vous ?"},
		{"4.0.1.0", "L'anomalie"},
		{"4.0.1.1", "Le civil"},
		{"4.1.0.0", "Je vois. C'est donc ce que vous avez fait ce jour-là ?..."},
		//level 3

		{"5.0.0.0", "Savez vous combien de gens vous avez laissé mourir ?"},
		{"5.0.1.0", "J'ai fait tout mon possible pour réduire le nombre de victimes !"},
		{"5.0.1.1", "Et vous, combien en avez vous sauvé ?"},
		{"5.0.1.2", "Je ne sais plus, je n'ai pas compté"},
		{"5.1.0.0", "Comment vous sentez-vous désormais, monsieur Smith ?"},
		{"5.1.1.0", "Bien mieux, merci. Vous m'avez rassuré"},
		{"5.1.1.1", "À votre avis ? Vous êtes une personne horrible"},
		{"5.1.1.2", "Ça n'a pas changé..."}
	};

	public static String GetText(int phase, int theme, int character, int line){
		String text;
		_lines.TryGetValue (phase.ToString () + "."
						+ theme.ToString() + "." 
						+ character.ToString () + "." 
						+ line.ToString (), 
						out text);
		if (text == null) {
			return "";
		}
		return text;
	}
}

