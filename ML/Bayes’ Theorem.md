# Bayes’ Theorem

## Q1 - What's Baye's Theorem

Bayes’ Theorem gives you the posterior probability of an event given what is known as prior knowledge.

Mathematically, it’s expressed as the true positive rate of a condition sample divided by the sum of the false positive rate of the population and the true positive rate of a condition. 

Say you had a 60% chance of actually having the flu after a flu test, but out of people who had the flu, the test will be false 50% of the time, and the overall population only has a 5% chance of having the flu. Would you actually have a 60% chance of having the flu after having a positive test?

Bayes’ Theorem says no. It says that you have a (.6 * 0.05) (True Positive Rate of a Condition Sample) / (.6*0.05)(True Positive Rate of a Condition Sample) + (.5*0.95) (False Positive Rate of a Population)  = 0.0594 or 5.94% chance of getting a flu.

## Q2 - Why is “Naive” Bayes naive?
More reading: Why is “naive Bayes” naive? (Quora)
Despite its practical applications, especially in text mining, Naive Bayes is considered “Naive” because it makes an assumption that is virtually impossible to see in real-life data: the conditional probability is calculated as the pure product of the individual probabilities of components. This implies the absolute independence of features — a condition probably never met in real life.
As a Quora commenter put it whimsically, a Naive Bayes classifier that figured out that you liked pickles and ice cream would probably naively recommend you a pickle ice cream.

## Q3 - What’s the difference between probability and likelihood?

### Probability

Probability refers to **chance**. It speaks about something that is likely to happen. Moreover, the word probability indicates the meaning of ‘being probable’ or ‘chancy’ as in the expression ‘in all probability’. The word probability indicates the sense of ‘the state or condition of being probable’. It indicates the chance of something happening.

Probability is a statistical application that involves permutation and combination. Probability in mathematics is a very important topic. In mathematics, probability means how likely something is going to happen. This is calculated using the total number of chances and the number of chances the desired outcome can occur. For example, think of a coin. It has two sides, Heads and Tails. When the coin is tossed, there are two outcomes. It can land Head or Tails. So, the total number of outcomes is two. Landing either Head or Tails is ½. This is the probability of landing either Heads or Tails.

### Likelihood

Likelihood refers to **possibility**. It shows how much possibility there is for something to happen. The word likelihood indicates the meaning of ‘being likely’ as in the expression ‘in all likelihood’. It is interesting to note that the word likelihood is often followed by the preposition ‘of’. Look at the following example.

The new graduates do not see any likelihood of finding any job with the current state of the economy.

In this sentence, the word likelihood means possibility. So, it says that the new graduates do not see any possibility of finding any job with the current state of the economy.

When it comes to mathematics, likelihood speaks of a function that is considered to be weaker than the probability. For example, let us consider a spinner that is divided to 8 equal parts. Four of them are numbered as number 3. Two are numbered as number 1, one as number 4 and one as number 5. The probability of the spinner landing on number 3 is higher. The likelihood of it landing on number 4 or 5 is very low.

What is the difference between Likelihood and Probability?

- The word likelihood refers to possibility. On the other hand, the word probability refers to ‘chance’. This is the main difference between the two words, namely, likelihood and probability.

- The word likelihood indicates the meaning of ‘being likely’ as in the expression ‘in all likelihood’. On the other hand, the word probability indicates the meaning of ‘being probable’ or ‘chancy’ as in the expression ‘in all probability’.

- In mathematics, probability is the chance that something can happen out of the total outcomes. This is calculated using the total number of chances and the number of chances the desired outcome can occur. Likelihood is a function weaker than probability. So, likelihood is lower in number.

- It is interesting to note that the word likelihood is often followed by the preposition ‘of’. At the same time, the word probability is also often followed by the preposition ‘of’.

- The word probability has an adjective called probable and adverb called probably.

- The word likelihood has an adjective called like and adverb called likely.

These are the differences between likelihood and probability.