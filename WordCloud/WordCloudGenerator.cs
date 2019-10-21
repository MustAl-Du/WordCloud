using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WordCloud;

namespace WordCloudSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Install NuGet WordCloud 1.0.0.3
            // include using for WordCloud and System.Drawing.
            // The output JPG resolution is set here to 1024x768
            WordCloud.WordCloud wc = new WordCloud.WordCloud(1024, 768, true);

            // Provide the text, from which the word cloud will be generated
            var text = "Unsatisfactory Holiday at Hotel Balfour, Torrevieja on 12 August 2014 to 19 August 2014 Booking ref: 123456789 I have just returned from a holiday at Hotel Balfour, Torrevieja with my wife and children, which was most disappointing.Please find below a list of our complaints: 1) There was no shower in the hotel as specified in the brochure 2) The kitchens were closed for the whole of our stay 3) The hotel was 5 miles from the beach and not 1 mile as it said in the brochure We contacted your representative at the resort on 14 August 2015, but they were unable to resolve the matter and advised us to complain upon our return home.Under The Package Travel, Package Holidays and Package Tours Regulations 1992 you have a responsibility to provide all the elements of the package contracted for as they were described.We are legally entitled to receive compensation from you for loss of value, consequential losses and for the disappointment and loss of enjoyment we suffered.As you failed to provide us with the holiday we booked we are seeking £150 compensation from you for the problems we encountered, and for the distress and disappointment we suffered as a result.I have also sent a copy of this letter and enclosure to ABTA(of which I note you are a member).I look forward to receiving a response from you within 14 days of receipt of this letter.";

            // TODO: submit text to Azure Cognitive Services (Text Analytics) to exract key phrases and words. Below is a smaple of these words
            List<String> words = new List<string> {
                "Holiday", "Hotel Balfour", "Torrevieja", "disappointment", "letter",
                "compensation", "brochure", "complaints", "representative", "resort",
                "matter", "return home", "response", "problems", "distress", "result"};
                        
            // TODO: write a mehtod to find the occurances/frequency of every key phrase in the text, Below is a sample of these frequencies
            List<int> frequencies = new List<int> { 4,2,2,2,2,2,2,1,1,1,1,1,1,1,1,1 };

            wc.Draw(words, frequencies).Save(@".\WordCloud.JPG");
        }
    }
}
