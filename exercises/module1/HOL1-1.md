# Lab 1.1 - Prompting and Performance Tuning

In this lab, you will explore GitHub Models and learn the fundamentals of prompt engineering. You will experiment with system and user prompts, model parameters such as temperature and top-p, and evaluate how different configurations influence the model’s output.

---

## Enable GitHub Models

**Goal:** Enable GitHub Models in your repository and open the Playground to run your first prompts.

### Steps

1. Go to your **GitHub repository**.

2. Click **Settings**.

3. In the left menu, locate and enable **Models**.

4. Confirm that the **Models** menu appears at the top.

   * If it does not appear, perform a hard refresh (`Ctrl+Shift+R` or `Cmd+Shift+R`).

   ![](./images/Models-Menu.png)

5. Click **Models** in the top menu.

6. Open **Playground**.

7. Select the **OpenAI GPT-4.1** model from the list.

---

## Prompting Basics

**Goal:** Understand how prompt wording, role, tone, and structure affects model responses.

### Steps

1. In **GitHub Models → Playground**, select **OpenAI GPT-4.1**.

2. Paste the following user prompt:

   ```txt
   Write an email to a GloboTicket customer explaining a refund is approved for order #GT-48321.
   ```

3. Add this system prompt and run again:

   ```txt
   You are a GloboTicket support agent. Tone: warm but concise. ≤120 words. Include refund amount and resolution time (3–5 business days).
   ```

4. Change only the tone and re-run:

   * “Use a formal tone of voice.”
   * “Use a ‘pop rock fan’ tone of voice.”

5. Add structure to the system prompt and run again:

   ```txt
   Use greeting, 3 bullet points, closing.
   ```

> Reflect: How did the output change with each adjustment? Which part—role, tone, or structure—had the largest impact?

---

## Temperature and Creativity

**Goal:** Observe how the temperature parameter affects creativity and randomness in model responses.

### Steps

1. Use this prompt:

   ```txt
   Suggest a place to eat before a concert at Madison Square Garden.
   ```

2. Set **temperature = 0** (factual) and run.
   Then set **temperature = 1.0** (creative) and run again.

> Reflect: When would you prefer a high temperature, and when a low one?

---

## Top-P vs. Temperature

**Goal:** Compare how `top_p` (nucleus sampling) and `temperature` influence variety and quality of responses.

### Steps

1. Keep **temperature = 0.7** and use this prompt:

   ```txt
   List 10 perks of buying early for GloboTicket shows.
   ```

2. Run once with **top_p = 0.3**, and again with **top_p = 0.9**.

3. Now fix **top_p = 1.0** and try the same prompt with **temperature = 0.2**, **0.7**, and **1.0**.

> Reflect: Which combination produced the most interesting yet relevant output? How would you describe the difference between `top_p` and `temperature`?

---

## Frequency and Presence Penalty

**Goal:** Reduce repetition and increase variation—important when generating lists or FAQs.

### Steps

1. Retrieve a **venue policy** (Markdown) from your exercise folder (for example, Ziggo Dome).

2. Paste the following prompt and include your policy after the separator:

   ```txt
   ## From the policy below, generate 12 distinct customer FAQs with answers. Avoid repeating phrasing.
   ---
   [PASTE POLICY HERE]
   ```

3. Run with **frequency_penalty = 0** and **presence_penalty = 0**.

4. Run again with **frequency_penalty = 0.7** and **presence_penalty = 0.7**.

> Reflect: What changed between runs? Did the model create more diverse questions or simply rephrase existing ones?

---

## Multi-Step Prompt Engineering

**Goal:** Create a sequence that transforms free text into structured data, as in real-world LLM-powered applications.

### Steps

1. Use one venue policy (Markdown) as input.

2. Generate a short summary:

   ```txt
   Summarize this policy for support agents (≤120 words).
   ```

3. Extract structured JSON:

   ```txt
   Extract into JSON with keys: {bag_max_cm:[L,W,H], backpacks_rule, bottle_empty_allowed, reentry, cashless, service_animals_only, accessibility:{wheelchair,lifts,hearing_loops}}. Output ONLY JSON.
   ```

> Reflect: How could you automate these steps to power real-time customer support or web APIs?

---

## Model Comparison

**Goal:** Evaluate differences in tone, speed, reasoning, and creativity across models.

### Steps

1. Select two models in GitHub Models, such as **OpenAI GPT-4.1** and **Grok 3 Mini**.

2. Use this prompt for both:

   ```txt
   Draft a 100-word apology email for a payment outage impacting 2% of GloboTicket checkouts in the EU on 2025-09-28. Include next steps and refund guidance.
   ```

3. Have each model self-evaluate:

   ```txt
   Create a quick scorecard: Tone, Clarity, Actionability, Factual control, Hallucinations.
   ```

4. (Optional) Ask for a **PowerShell script** to send the email.

> Reflect: Which model generated the most usable output? Which evaluation criteria mattered most for your scenario?

---

This concludes Lab 1.1.
