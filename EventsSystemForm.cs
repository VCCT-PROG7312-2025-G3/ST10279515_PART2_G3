using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalServicesAppPOE
{
    public partial class EventsSystemForm : Form
    {
        // Data Structures
        private Stack<Event> recentlyViewedEvents = new Stack<Event>();
        private Queue<Event> eventQueue = new Queue<Event>();
        private Dictionary<string, List<Event>> eventsByCategory = new Dictionary<string, List<Event>>();
        private HashSet<string> uniqueCategories = new HashSet<string>();

        public EventsSystemForm()
        {
            InitializeComponent();
            LoadSampleEvents();
        }

        private void LoadSampleEvents()
        {
            // Add sample events
            var events = new List<Event>
            {
                new Event { Title = "Community Clean-up Day", Category = "Environment", Date = DateTime.Now.AddDays(2), Location = "City Park", Priority = 2 },
                new Event { Title = "Town Hall Meeting", Category = "Government", Date = DateTime.Now.AddDays(5), Location = "Municipal Building", Priority = 1 },
                new Event { Title = "Youth Sports Tournament", Category = "Sports", Date = DateTime.Now.AddDays(7), Location = "Sports Complex", Priority = 3 },
                new Event { Title = "Public Budget Review", Category = "Government", Date = DateTime.Now.AddDays(3), Location = "Council Chambers", Priority = 1 },
                new Event { Title = "Farmers Market", Category = "Community", Date = DateTime.Now.AddDays(1), Location = "Main Square", Priority = 3 },
                new Event { Title = "Road Maintenance Notice", Category = "Infrastructure", Date = DateTime.Now.AddDays(4), Location = "Various Locations", Priority = 2 },
                new Event { Title = "Emergency Water Shutdown", Category = "Utilities", Date = DateTime.Now.AddHours(6), Location = "Suburb A", Priority = 1 },
                new Event { Title = "Library Book Sale", Category = "Community", Date = DateTime.Now.AddDays(10), Location = "Public Library", Priority = 3 }
            };

            foreach (var eventItem in events)
            {
                eventQueue.Enqueue(eventItem);

                if (!eventsByCategory.ContainsKey(eventItem.Category))
                    eventsByCategory[eventItem.Category] = new List<Event>();
                eventsByCategory[eventItem.Category].Add(eventItem);

                uniqueCategories.Add(eventItem.Category);

                listBoxEvents.Items.Add($"{eventItem.Title} - {eventItem.Date:MMM dd} ({eventItem.Category})");
            }

            // Populate category filter
            comboBoxCategory.Items.Add("All Categories");
            foreach (var category in uniqueCategories)
            {
                comboBoxCategory.Items.Add(category);
            }
            comboBoxCategory.SelectedIndex = 0;

            GenerateRecommendations();
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Search events...")
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                textBoxSearch.Text = "Search events...";
                textBoxSearch.ForeColor = Color.Gray;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchEvents();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterEvents();
        }

        private void listBoxEvents_DoubleClick(object sender, EventArgs e)
        {
            ViewEventDetails();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            ViewEventDetails();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Close();
        }

        // ADD THIS MISSING METHOD - Fixes the error
        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Close();
        }

        private void SearchEvents()
        {
            string searchTerm = textBoxSearch.Text.ToLower();
            if (string.IsNullOrEmpty(searchTerm) || searchTerm == "search events...")
            {
                LoadAllEvents();
                return;
            }

            listBoxEvents.Items.Clear();
            foreach (var category in eventsByCategory.Values)
            {
                foreach (var eventItem in category)
                {
                    if (eventItem.Title.ToLower().Contains(searchTerm) ||
                        eventItem.Category.ToLower().Contains(searchTerm) ||
                        eventItem.Location.ToLower().Contains(searchTerm))
                    {
                        listBoxEvents.Items.Add($"{eventItem.Title} - {eventItem.Date:MMM dd} ({eventItem.Category})");
                    }
                }
            }
        }

        private void FilterEvents()
        {
            string selectedCategory = comboBoxCategory.SelectedItem.ToString();
            if (selectedCategory == "All Categories")
            {
                LoadAllEvents();
            }
            else
            {
                listBoxEvents.Items.Clear();
                foreach (var eventItem in eventsByCategory[selectedCategory])
                {
                    listBoxEvents.Items.Add($"{eventItem.Title} - {eventItem.Date:MMM dd} ({eventItem.Category})");
                }
            }
        }

        private void LoadAllEvents()
        {
            listBoxEvents.Items.Clear();
            foreach (var category in eventsByCategory.Values)
            {
                foreach (var eventItem in category)
                {
                    listBoxEvents.Items.Add($"{eventItem.Title} - {eventItem.Date:MMM dd} ({eventItem.Category})");
                }
            }
        }

        private void ViewEventDetails()
        {
            if (listBoxEvents.SelectedItem != null)
            {
                string selectedText = listBoxEvents.SelectedItem.ToString();
                string eventTitle = selectedText.Split('-')[0].Trim();

                // Find the event
                Event selectedEvent = null;
                foreach (var category in eventsByCategory.Values)
                {
                    selectedEvent = category.Find(e => e.Title == eventTitle);
                    if (selectedEvent != null) break;
                }

                if (selectedEvent != null)
                {
                    // Add to recently viewed stack (LIFO - Last In First Out)
                    recentlyViewedEvents.Push(selectedEvent);
                    UpdateRecentViews();

                    // Professional dialog with more details
                    string priorityText = selectedEvent.Priority switch
                    {
                        1 => "🔴 HIGH PRIORITY - Urgent Attention Required",
                        2 => "🟡 MEDIUM PRIORITY - Important Notice",
                        3 => "🟢 LOW PRIORITY - General Information",
                        _ => "⚪ STANDARD"
                    };

                    string message = $@"📅 EVENT DETAILS

🏛️ {selectedEvent.Title}
📋 Category: {selectedEvent.Category}
📍 Location: {selectedEvent.Location}
🗓️ Date: {selectedEvent.Date:dddd, MMMM dd, yyyy}
🕒 Time: {selectedEvent.Date:hh:mm tt}
{priorityText}

📝 Description:
This community event is organized by your local municipality to enhance citizen engagement and service delivery. Your participation helps build a stronger community.

💡 Data Structures Used:
• Stack (Recently Viewed): LIFO principle
• Queue (Event Order): FIFO principle  
• Dictionary (Categories): Fast lookups
• HashSet (Unique Values): No duplicates

Thank you for your civic engagement! 🎉";

                    MessageBox.Show(message, "Event Information - Municipal Services",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select an event to view details.", "Selection Required",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateRecentViews()
        {
            listBoxRecentViews.Items.Clear();
            foreach (var item in recentlyViewedEvents)
            {
                listBoxRecentViews.Items.Add($"{item.Title} ({item.Date:MMM dd})");
            }
        }

        private void GenerateRecommendations()
        {
            // High priority events from priority queue concept
            listBoxRecommendations.Items.Add("🔴 HIGH PRIORITY EVENTS");
            listBoxRecommendations.Items.Add("(Based on Municipal Urgency)");
            listBoxRecommendations.Items.Add("");

            var highPriority = new List<Event>();
            foreach (var category in eventsByCategory.Values)
            {
                highPriority.AddRange(category.FindAll(e => e.Priority == 1));
            }

            if (highPriority.Count > 0)
            {
                foreach (var eventItem in highPriority.Take(3))
                {
                    listBoxRecommendations.Items.Add($"• {eventItem.Title}");
                    listBoxRecommendations.Items.Add($"  📍 {eventItem.Location}");
                    listBoxRecommendations.Items.Add($"  🗓️ {eventItem.Date:MMM dd, yyyy}");
                    listBoxRecommendations.Items.Add("");
                }
            }
            else
            {
                listBoxRecommendations.Items.Add("No high priority events");
                listBoxRecommendations.Items.Add("");
            }

            // Upcoming events from queue (FIFO)
            listBoxRecommendations.Items.Add("📅 UPCOMING EVENTS");
            listBoxRecommendations.Items.Add("(Chronological Order - Queue)");
            listBoxRecommendations.Items.Add("");

            var upcoming = eventQueue.Take(3).ToList();
            if (upcoming.Count > 0)
            {
                foreach (var eventItem in upcoming)
                {
                    listBoxRecommendations.Items.Add($"• {eventItem.Title}");
                    listBoxRecommendations.Items.Add($"  🏷️ {eventItem.Category}");
                    listBoxRecommendations.Items.Add($"  🗓️ {eventItem.Date:MMM dd}");
                    listBoxRecommendations.Items.Add("");
                }
            }

          

            if (recentlyViewedEvents.Count > 0)
            {
                var recentCategory = recentlyViewedEvents.Peek().Category;
                var similarEvents = eventsByCategory.ContainsKey(recentCategory)
                    ? eventsByCategory[recentCategory].Take(2)
                    : new List<Event>();

                foreach (var eventItem in similarEvents)
                {
                    listBoxRecommendations.Items.Add($"• {eventItem.Title}");
                    listBoxRecommendations.Items.Add($"  🏷️ {eventItem.Category}");
                    listBoxRecommendations.Items.Add("");
                }
            }
            else
            {
                listBoxRecommendations.Items.Add("View events to get");
                listBoxRecommendations.Items.Add("personalized suggestions");
                listBoxRecommendations.Items.Add("");
            }
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }
    }

    public class Event
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int Priority { get; set; } // 1 = High, 2 = Medium, 3 = Low
    }
}