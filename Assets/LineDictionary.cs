using System;
using System.Collections.Generic;

public static class DialogueList
{
	private static Dictionary<String, String> _lines = new Dictionary<String, String>{
		{"0.1.0.1", "Anomalie Smith, 34 ans, télékinésiste. C'est bien vous ?"},
		"Oui",
		"Savez-vous pourquoi nous sommmes ici ?",
			"Non, et vous ?",
			"Aucune idée",
			"Euuh... Oui je crois",
			"Pour parler du bon vieux temps.",
		"Nous sommes ici pour vous trouver une place dans notre société de paix, débarassée des derniers super-vilains. Répondez simplement à mes questions. Vous comprenez ?",
			"Compris",
			"Mhmh",
		"Tout d'abord, dîtes m'en plus sur votre pouvoir. Nous trouverons peut être un moyen de le rendre utile.",
		"Bien. Commencons l'entretien.",

		"Comment vous sentez-vous, monsieur Smith ?",
			"Très bien ! Vous savez mettre les gens à l'aise...",
			"Ça va... je crois",
			"À vrai dire, je vous trouve plutôt inquiétant",
			"Qu'est ce que ça peut vous faire ?",
		"Quelles sont vos ambitions actuelles ?",
			"Je cherche juste du travail",
			"Je veux sauver des vies. C'est ce que je fais de mieux",
			"Je souhaite devenir riche et célèbre",
		"Seriez vous capable de sauver des citoyens bloqués dans un immeuble suite à un séisme ?",
		"Monsieur Smih, vous m'écoutez toujours ?",
			"Oui oui.",
		"Bon réflexe. Ne m'en voulez pas, je ne fais que mon travail",
		"J'aimerai également vérifier vos capacités de raisonnement. Voici une suite de carte. Essayez de la compléter",
		"Supposons maintenant qu'une menace ait détruit la ville. Une anomalie et un citoyen sont sur le point de mourir et vous ne pouvez en sauver qu'un seul. Lequel choisissez-vous ?",
			"L'anomalie",
			"Le civil",
		"Je vois. C'est donc ce que vous avez fait ce jour-là ?...",
		"Savez vous combien de gens vous avez laissé mourir ?",
			"J'ai fait tout mon possible pour réduire le nombre de victimes !",
			"Et vous, combien en avez vous sauvé ?",
			"Je ne sais plus, je n'ai pas compté",
		"Comment vous sentez-vous désormais, monsieur Smith ?",
			"Bien mieux, merci. Vous m'avez rassuré",
			"À votre avis ? Vous êtes une personne horrible",
			"Ça n'a pas changé..."
		"N"
	};

	public static String GetText(int phase, int theme, int character, int line){
		String text;
		_lines.TryGetValue (phase.ToString () + "."
						+ theme.ToString() + "." 
						+ character.ToString () + "." 
						+ line.ToString (), 
						out text);
		return text;
	}
}

