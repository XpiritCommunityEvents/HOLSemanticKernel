## 1. Enable GitHub Models

### Step 1: Turn on Models in Your Repo
1. Go to your **GitHub repository**.
2. Click **Settings**.
3. In the left menu, find and enable **Models**.
4. Confirm the **Models** menu appears at the top.  
   - If not, **Hard Refresh** your browser (`Ctrl+Shift+R` or `Cmd+Shift+R`).

   ![](./images/Models-Menu.png)

### Step 2: Open the Playground
1. Click **Models** in the top menu.
2. Go to **Playground**.
3. Select the **OpenAI GPT-4.1** model from the list.

## 2. Prompting Basics

**Goal:** See how prompt wording (role, tone, detail) changes model responses—even with the same base question.

### Steps
1. In **GitHub Models → Playground**, pick **OpenAI GPT-4.1**.
2. Paste this user prompt:

```
Write an email to a GloboTicket customer explaining a refund is approved for order #GT-48321.
```
3. Add this to the **System Prompt** and re-run:

```
You are a GloboTicket support agent. Tone: warm but concise. ≤120 words. Include refund amount and resolution time (3–5 business days).
```

4. Re-run, each time changing only the **tone** in the system prompt:
- “Use a formal tone of voice.”
- “Use a 'pop rock fan' tone of voice.”
5. Add structure to the system prompt and re-run:

```
Use greeting, 3 bullet points, closing.
```

> 💡 **Reflect:** How much did the output change with each adjustment? Which part (role, tone, or structure) had the biggest effect?

## 3. Temperature & Creativity

**Goal:** See how the temperature setting controls creativity and randomness.

### Steps
1. Use this prompt:

```
Suggest a place to eat before a concert at Madison Square Garden.
```

2. Set **temperature = 0** (very factual) and run.  
Then, set **temperature = 1.0** (creative/varied) and run again.

> 💡 **Reflect:** For which types of applications would you want a high temperature? When would you prefer low?

## 4. Top-P vs. Temperature

**Goal:** Compare how `top_p` (nucleus sampling) and `temperature` change the variety and quality of responses.

### Steps
1. Keep **temperature = 0.7**. Use:

```
List 10 perks of buying early for GloboTicket shows.
```

2. Run once with **top_p = 0.3**, and once with **top_p = 0.9**.

3. Now fix **top_p = 1.0** and try the same prompt with temperature **0.2**, **0.7**, and **1.0**.

> 💡 **Reflect:** Which combination produced the most interesting but still relevant list?  
> Try to describe the difference between top-p and temperature in your own words.

## 5. Frequency & Presence Penalty

**Goal:** Learn to reduce repetition and increase variety—important for lists and FAQs.

### Steps
1. Grab a **venue policy** (Markdown) from your the exercise folder (e.g., Ziggo Dome).
2. Paste this prompt and add your policy after `---`:

```
## From the policy below, generate 12 distinct customer FAQs with answers. Avoid repeating phrasing.
---
[PASTE POLICY HERE]
```
3. Set **frequency_penalty = 0**, **presence_penalty = 0** and run.
4. Set **frequency_penalty = 0.7**, **presence_penalty = 0.7** and run again.

> 💡 **Reflect:** What changed? Did you see more diverse questions or just more creative wording?

---
## 6. Multi-Step Prompt Engineering
**Goal:** Go from free text → structured JSON → audience-specific outputs → model validation, just like in real-world LLM-powered apps.

### Steps
1. Input: **One venue policy** (Markdown).
2. Generate a summary

```
Summarize this policy for support agents (≤120 words).
```
3. Extract strict JSON

```
Extract into JSON with keys: {bag_max_cm:[L,W,H], backpacks_rule, bottle_empty_allowed, reentry, cashless, service_animals_only, accessibility:{wheelchair,lifts,hearing_loops}}. Output ONLY JSON.
```

> 💡 **Reflect:** How could you automate these steps in a pipeline to power real-time support, websites, or APIs?

## 6. Model Comparison Lab

**Goal:** Compare strengths and weaknesses across models—speed, tone, reasoning, creativity.

### Steps
1. Pick **two different models** in GitHub Models (e.g., OpenAI GPT-4.1 and Grok 3 Mini).
2. Use this prompt for both:

```
Draft a 100-word apology email for a payment outage impacting 2% of GloboTicket checkouts in EU on 2025-09-28. Include next steps & refund guidance.
```
3. Have the model **self-evaluate**. Prompt:

```
Create a quick scorecard: Tone, Clarity, Actionability, Factual control, Hallucinations.
```

4. Optional: Prompt for a **PowerShell script** to send the email.

> 💡 **Reflect:** Which model produced a more usable output? Which criteria mattered most for your scenario?

