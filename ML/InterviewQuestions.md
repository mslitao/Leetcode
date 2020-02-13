# Top Machine Learnng Interview Questions


## General Questions

### Q1 - What’s the trade-off between bias and variance?

+ Bias is error due to **erroneous or overly simplistic assumptions** in the learning algorithm you’re using. This can lead to the **model underfitting** your data, making it *hard for it to have high predictive accuracy* and for you to generalize your knowledge from the training set to the test set..

+ Variance is error due to **too much complexity** in the learning algorithm you’re using. This leads to the algorithm being highly sensitive to high degrees of variation in your training data, which can lead your model to overfit the data. You’ll be carrying **too much noise from your training data for your model** to be very useful for your test data.



The bias-variance decomposition essentially decomposes the learning error from any algorithm by adding the bias, the variance and a bit of irreducible error due to noise in the underlying dataset. Essentially, if you make the model more complex and add more variables, you’ll lose bias but gain some variance — in order to get the optimally reduced amount of error, you’ll have to tradeoff bias and variance. You don’t want either high bias or high variance in your model.

More reading:  [Bias-Variance Tradeoff (Wikipedia)](https://en.wikipedia.org/wiki/Bias–variance_tradeoff)

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

    Overfitting occurs when a statistical model or machine learning algorithm captures the noise of the data. Intuitively, overfitting occurs when the model or the algorithm fits the data too well. 

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

