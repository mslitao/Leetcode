# Top Machine Learnng Interview Questions


## General Questions

### Q1 - What’s the trade-off between bias and variance?

+ Bias is error due to **erroneous or overly simplistic assumptions** in the learning algorithm you’re using. This can lead to the **model underfitting** your data, making it *hard for it to have high predictive accuracy* and for you to generalize your knowledge from the training set to the test set..

+ Variance is error due to **too much complexity** in the learning algorithm you’re using. This leads to the algorithm being highly sensitive to high degrees of variation in your training data, which can lead your model to overfit the data. You’ll be carrying **too much noise from your training data for your model** to be very useful for your test data.



The bias-variance decomposition essentially decomposes the learning error from any algorithm by adding the bias, the variance and a bit of irreducible error due to noise in the underlying dataset. Essentially, if you make the model more complex and add more variables, you’ll lose bias but gain some variance — in order to get the optimally reduced amount of error, you’ll have to tradeoff bias and variance. You don’t want either high bias or high variance in your model.

More reading:  [Bias-Variance Tradeoff (Wikipedia)](https://en.wikipedia.org/wiki/Bias–variance_tradeoff)

Keywords: *simplifying assumptions*, *complexity*

### Bias Error


Bias are the **simplifying assumptions** made by a model to make the target function easier to learn.
Generally, linear algorithms have a high bias making them fast to learn and easier to understand but generally less flexible. In turn, they have lower predictive performance on complex problems that fail to meet the simplifying assumptions of the algorithms bias.

    • Low Bias: Suggests less assumptions about the form of the target function.

    • High-Bias: Suggests more assumptions about the form of the target function.

Examples of low-bias machine learning algorithms include:

    Decision Trees,
    KNN - k-Nearest Neighbors 
    SVM - Support Vector Machines.

Examples of high-bias machine learning algorithms include:

    Linear Regression
    Linear Discriminant Analysis
    Logistic Regression.
 
Bias = Assumptions made by a model to make the target function or learn the model

So, simple model usually has a lot of assumptions then the bias will also be higher as well. For example, linear regression, logistic regression. These model is not easy to overfit
Overfit is mostly happened for the Low Bias and high variance 

For the complex model, it doesn't need so complicated assumptions to learn the model. So, it should be low bias. But this will tend to be high variance, the  easier to be overfitted. 

### Variance Error

Variance is the amount that the estimate of the target function will change if different training data was used.

The target function is estimated from the training data by a machine learning algorithm, so we should expect the algorithm to have some variance. Ideally, it should not change too much from one training dataset to the next, meaning that the algorithm is good at picking out the hidden underlying mapping between the inputs and the output variables.

Machine learning algorithms that have a high variance are strongly influenced by the specifics of the training data. This means that the specifics of the training have influences the number and types of parameters used to characterize the mapping function.

    • Low Variance: Suggests small changes to the estimate of the target function with changes to the training dataset.

    • High Variance: Suggests large changes to the estimate of the target function with changes to the training dataset.

Generally, **nonlinear machine learning algorithms that have a lot of flexibility have a high variance**. For example, decision trees have a high variance, that is even higher if the trees are not pruned before use.

Examples of low-variance machine learning algorithms include: 

    Linear Regression
    Linear Discriminant Analysis
    Logistic Regression.
Examples of high-variance machine learning algorithms include: 
    Decision Trees,
    k-Nearest Neighbors
    Support Vector Machines.


### Q2 - Overfitting and Underfitting

In Machine learning, generalization usually refers to the ability of an algorithm to be effective across a range of inputs and applications.

Suppose that we are designing a machine learning model. How a model is said to be a good machine learning model? By Checking if it generalizes any new input data from the problem domain in a proper way. This helps us to make predictions in the future data, the data model has never seen.

* A model is good if it neither underfit or overfits 


1. Underfitting:

     A statistical model is said to have underfitting when it cannot capture the underlying trend of the data. If the data contains too much information that the model cannot take, the model is going to underfit for sure.

    It usually happens if 
	1. We have less data to train the model
	2. Or quite high amount of features
	3. When we try to build a linear model with a non-linear data
	4. Too simple model
    
    The machine learning model are too easy and flexible to be applied on such a minimal data and therefore the model will probably make a lot of wrong predictions.


    **Low Variance but high bias.**

2. Overfitting

    Overfitting occurs when a statistical model or machine learning algorithm captures **the noise of the data**. Intuitively, overfitting occurs when the model or the algorithm **fits the data too well**. 

    **The model is Low bias but high variance**

    an excessively complicated model applied to a not so complicated dataset.

    How to avoid the overfitting
	1. Cross - Validation: K-fold cross validation. Partition the data into k subsets, called folds. Then iteratively train the model on k-1 folds while using the remaining fold as the test set.
	2. Train with mode data
	Won't work every time. Training with more data can help the algorithms detect the signal better. But if you add more noisy data, this will not help. You must make sure the data is clean and relevant.
	3. Remove the features
	Manually remove the irrelevant input features to improve the model generalizability.
	4. Early Stopping
	When we train the mode, we can measure how well each iteration of the model perform. 
	Up until a certain number of iterations, new iterations improve the model. After that point, however, the model's ability to generalize can weaken as it begins to overfit the training data.
	5. Regularization
	Regularization refers to a broad range of techiniques forcing your model to be simpler. 
	    
        * For example, prune a decision tree, dropout 
	    * Add a penalty parameter to the cost function in regression

### Q2 - Overfitting and Underfitting
