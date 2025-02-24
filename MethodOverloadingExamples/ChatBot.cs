using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExamples
{
    class ChatBot
    {
        private Dictionary<string, string> languageResponses = new Dictionary<string, string>
    {
        { "english", "Hello! How can I assist you?" },
        { "spanish", "¡Hola! ¿Cómo puedo ayudarte?" },
        { "french", "Bonjour! Comment puis-je vous aider?" },
        { "german", "Hallo! Wie kann ich Ihnen helfen?" }
    };

        public void RespondToQuery(string query)
        {
            Console.WriteLine($"Chatbot: Thank you for your query. We are looking into: \"{query}\".");
        }

        public void RespondToQuery(string query, string priority)
        {
            Console.WriteLine($"Chatbot: Your priority query \"{query}\" has been marked as '{priority}'. Our team will respond ASAP.");
        }

        public void RespondToQuery(string query, string priority, string language)
        {
            language = language.ToLower();
            if (languageResponses.ContainsKey(language))
            {
                Console.WriteLine($"Chatbot ({language.ToUpper()}): {languageResponses[language]} We are processing: \"{query}\" with priority '{priority}'.");
            }
            else
            {
                Console.WriteLine($"Chatbot: Sorry, we don't support {language} yet. Processing: \"{query}\" with priority '{priority}'.");
            }
        }
    }
}
