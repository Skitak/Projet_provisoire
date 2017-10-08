using System;
using System.Collections.Generic;

public static class DialogueList
{
	private static Dictionary<String, String> _lines = new Dictionary<String, String>{
		{"0.1.0.1", "Anomalie Smith, 34 ans, télékinésiste. C'est bien vous ?"},
		{"0.1.1.1", "Oui"},
		{"0.2.0.1","Savez-vous pourquoi nous sommmes ici ?"},
		{"0.2.1.1", "Non, et vous ?"},
		{"0.2.1.2","Aucune idée"},
		{"0.2.1.3", "Euuh... Oui je crois"},
		{"0.2.1.4", "Pour parler du bon vieux temps."},
		{"0.3.0.1", "Nous sommes ici pour vous trouver une place dans notre société de paix, débarassée des derniers super-vilains. Répondez simplement à mes questions. Vous comprenez ?"},
		{"0.3.1.1", "Compris"},
		{"0.3.1.2", "Mhmh"},
		{"0.4.0.1", "Tout d'abord, dîtes m'en plus sur votre pouvoir. Nous trouverons peut être un moyen de le rendre utile."},
		{"0.5.0.1", "Bien. Commencons l'entretien."},

		{"1.1.0.1", "Comment vous sentez-vous, monsieur Smith ?"},
		{"1.1.1.1", "Très bien ! Vous savez mettre les gens à l'aise..."},
		{"1.1.1.2", "Ça va... je crois"},
		{"1.1.1.3", "À vrai dire, je vous trouve plutôt inquiétant"},
		{"1.1.1.4", "Qu'est ce que ça peut vous faire ?"},
		{"1.2.0.1", "Quelles sont vos ambitions actuelles ?"},
		{"1.2.1.1", "Je cherche juste du travail"},
		{"1.2.1.2", "Je veux sauver des vies. C'est ce que je fais de mieux"},
		{"1.2.1.3", "Je souhaite devenir riche et célèbre"},
		{"1.3.0.1", "Seriez vous capable de sauver des citoyens bloqués dans un immeuble suite à un séisme ?"},

		{"2.1.0.1", "Monsieur Smih, vous m'écoutez toujours ?"},
		{"2.1.1.1", "Oui oui."},
		{"2.2.0.1", "Bon réflexe. Ne m'en voulez pas, je ne fais que mon travail"},
		{"2.3.0.1", "J'aimerai également vérifier vos capacités de raisonnement. Voici une suite de carte. Essayez de la compléter"},
		{"2.4.0.1", "Supposons maintenant qu'une menace ait détruit la ville. Une anomalie et un citoyen sont sur le point de mourir et vous ne pouvez en sauver qu'un seul. Lequel choisissez-vous ?"},
		{"2.4.1.1", "L'anomalie"},
		{"2.4.1.2", "Le civil"},
		{"2.5.0.1", "Je vois. C'est donc ce que vous avez fait ce jour-là ?..."},

		{"3.1.0.1", "Savez vous combien de gens vous avez laissé mourir ?"},
		{"3.1.1.1", "J'ai fait tout mon possible pour réduire le nombre de victimes !"},
		{"3.1.1.2", "Et vous, combien en avez vous sauvé ?"},
		{"3.1.1.3", "Je ne sais plus, je n'ai pas compté"},
		{"3.2.0.1", "Comment vous sentez-vous désormais, monsieur Smith ?"},
		{"3.2.1.1", "Bien mieux, merci. Vous m'avez rassuré"},
		{"3.2.1.2", "À votre avis ? Vous êtes une personne horrible"},
		{"3.2.1.3", "Ça n'a pas changé..."}
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

