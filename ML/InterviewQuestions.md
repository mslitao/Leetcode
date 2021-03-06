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

    • Low Variance:
    Suggests small changes to the estimate of the target function with changes to the training dataset.

    • High Variance: 
    Suggests large changes to the estimate of the target function with changes to the training dataset.

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

## Q3- What is the difference between supervised and unsupervised machine learning?
More reading: What is the difference between supervised and unsupervised machine learning? (Quora)

![supervised-vs-unsupervised](../img/supervised-vs-unsupervised.jpg "Supervised vs Unsupervised")



### Supervised Learning
Supervised learning requires training labeled data. For example, in order to do classification (a supervised learning task), you’ll need to first label the data you’ll use to train the model to classify data into your labeled groups. 

### Unsupervised Learning
Unsupervised learning, in contrast, does not require labeling data explicitly.



## Q4 - How is KNN different from k-means clustering?

More reading: How is the k-nearest neighbor algorithm different from k-means clustering? (Quora)

1. Different on K

    * KNN: K is neighbors count
    * K-means: K is the cluster count 

2. supervised classification vs unsupervised clustering
    
    * K-Nearest Neighbors is a supervised classification algorithm
    * k-means clustering is an unsupervised clustering algorithm. 

While the mechanisms may seem similar at first, what this really means is that in order for K-Nearest Neighbors to work, you need labeled data you want to classify an unlabeled point into (thus the nearest neighbor part). 

K-means clustering requires only a set of unlabeled points and a threshold: the algorithm will take unlabeled points and gradually learn how to cluster them into groups by computing the mean of the distance between different points.

The critical difference here is that KNN needs labeled points and is thus supervised learning, while k-means doesn’t — and is thus unsupervised learning.



## Q5 - Explain how a ROC curve works.

More reading: Receiver operating characteristic (Wikipedia)

The ROC curve is a graphical representation of the contrast between **true positive rates** and the **false positive rate** at various thresholds.


It’s often used as a proxy for the trade-off between the sensitivity of the model (true positives) vs the fall-out or the probability it will trigger a false alarm (false positives).

![roc-curve](../img/roc-curve.png "ROC curve")

## Q6 - Define precision and recall.

More reading: Precision and recall (Wikipedia)

### Recall

**true positive rate**

Recall is also known as the **true positive rate**: the amount of positives your model claims compared to the actual number of positives there are throughout the data. 

### Precision

**accurate positives**

Precision is also known as the positive predictive value, and it is a measure of the amount of accurate positives your model claims compared to the number of positives it actually claims.

![precision-vs-recall](../img/precision-vs-recall.png "Precision VS Recall")

## Q7 - Regularisation

Regularisation is a process of introducing additional information in order to prevent overfitting. The focus for this article is L1 and L2 regularisation.

Regularization helps to solve over fitting problem in machine learning. Simple model will be a very poor generalization of data.At the same time, complex model may not perform well in test data due to over fitting. We need to choose the right model in between simple and complex model. 

Regularization helps to choose preferred model complexity, so that model is better at predicting. Regularization is nothing but adding a **penalty term** to the objective function and **control the model complexity** using that penalty term. It can be used for many machine learning algorithms. I have attempted to explain the regularization using the ridge and lasso regression.


## Q7 - L1 and L2 error

L1-norm loss function is also known as least absolute deviations (LAD), least absolute errors (LAE). It is basically minimizing the sum of the absolute differences (S) between the target value (Yi) and the estimated values (f(xi)):

$$ S = \sum_{i=0}^n|y_i - h(x_i)|$$

L2-norm loss function is also known as least squares error (LSE). It is basically minimizing the sum of the square of the differences (S) between the target value (Yi) and the estimated values (f(xi):

$$ S = \sum_{i=0}^n(y_i - h(x_i))^2 $$

Intuitively speaking, since a L2-norm squares the error (increasing by a lot if error > 1), the model will see a much larger error ( e vs e^2 ) than the L1-norm, so the model is much more sensitive to this example, and adjusts the model to minimize this error. If this example is an outlier, the model will be adjusted to minimize this single outlier case, at the expense of many other common examples, since the errors of these common examples are small compared to that single outlier case.

**L1 loss function is more robust**

As a result, L1 loss function is more robust and is generally not affected by outliers. On the contrary L2 loss function will try to adjust the model according to these outlier values, even on the expense of other samples. Hence, L2 loss function is highly sensitive to outliers in the dataset.


More details here: http://rishy.github.io/ml/2015/07/28/l1-vs-l2-loss/ 

With outliers in the dataset, a L2(Loss function) tries to adjust the model according to these outliers on the expense of other good-samples, since the squared-error is going to be huge for these outliers(for error > 1). 

On the other hand L1(Least absolute deviation) is quite resistant to outliers.

As a result, L2 loss function may result in huge deviations in some of the samples which results in reduced accuracy.

So, if you can ignore the ouliers in your dataset or you need them to be there, then you should be using a L1 loss function, on the other hand if you don’t want undesired outliers in the dataset and would like to use a stable solution then first of all you should try to remove the outliers and then use a L2 loss function. Or performance of a model with a L2 loss function may deteriorate badly due to the presence of outliers in the dataset.

Whenever in doubt, prefer L2 loss function, it works pretty well in most of the situations.

## Q8- Explain the difference between L1 and L2 regularization.


![l1-l2](../img/loss-function-l1-l2.PNG "L1 regularisation vs L2 regularisation")

You can also think of L1 as reducing the number of features in the model altogether

Please read more details here:
https://towardsdatascience.com/intuitions-on-l1-and-l2-regularisation-235f2db4c261


https://www.quora.com/What-is-the-difference-between-L1-and-L2-regularization-How-does-it-solve-the-problem-of-overfitting-Which-regularizer-to-use-and-when


The main difference between L1 and L2 regularization is that L1 can yield sparse models while L2 doesn't. Sparse model is a great property to have when dealing with high-dimensional data, for at least 2 reasons.

Model compression: increasingly important due to the mobile growth

Feature selection: it helps to know which features are important and which features are not or redundant.

## Q9 - Model of Lasso 

The Lasso regression uses L1 norm for regularization. The main difference between ridge and lasso regression is a shape of the constraint region. Ridge regression use L2 norm.Lasso uses L1norm for a constraint. For P = 2 case, the shape of the constraint region is diamond. The Lasso estimate is an estimate which minimizes the sum of square as well as satisfy the below constraint.

Use L1 regularization, works better on feature selection.

The main advantage of using Lasso regression for feature selection over other subset selection method (Forward.other method regression) is that it uses convex optimisation to find out the best features. So, it converges faster compared to backward


## Q10 - Model of ridge
Use L2 regulariation

How ridge regression solves over fitting problem?

The ridge regression has two important advantages over the linear regression. 

The most important one is that it penalizes the estimates. It doesn't penalize all the feature’s estimate arbitrarily. If estimates (β) value are very large, then the SSE term in the above equation will minimize, but the penalty term will increases. If estimates(β)values are small, then the penalty term in the above equation will minimize, but, the SSE term will increase due to poor generalization. So, it chooses the feature's estimates (β) to penalize in such a way that less influential features (Some features cause very small influence on dependent variable) undergo more penalization.

In some domains, the number of independent variables is many, as well as we are not sure which of the independent variables influences dependent variable. In this kind of scenario, ridge regression plays a better role than linear regression.


## Q11 - Elastic Net

However, I would like to add one more Regularization method of **Elastic Net** which is a combination of the two. It combines both the penalties of L1 and L2.

## Q12- What’s the difference between Type I and Type II error?
More reading: Type I and type II errors (Wikipedia)

Don’t think that this is a trick question! Many machine learning interview questions will be an attempt to lob basic questions at you just to make sure you’re on top of your game and you’ve prepared all of your bases.

Type I error is a false positive, while Type II error is a false negative. Briefly stated, Type I error means claiming something has happened when it hasn’t, while Type II error means that you claim nothing is happening when in fact something is.

A clever way to think about this is to think of Type I error as telling a man he is pregnant, while Type II error means you tell a pregnant woman she isn’t carrying a baby.

## Q13 - What cross-validation technique would you use on a time series dataset?

Instead of using standard k-folds cross-validation, you have to pay attention to the fact that a time series is not randomly distributed data — it is inherently ordered by chronological order. If a pattern emerges in later time periods for example, your model may still pick up on it even if that effect doesn’t hold in earlier years!

You’ll want to do something like forward chaining where you’ll be able to model on past data then look at forward-facing data.

You need some kind of assurance that your model has got most of the patterns from the data correct, and its not picking up too much on the noise, or in other words its low on bias and variance.

Generally, an error estimation for the model is made after training, better known as evaluation of residuals. In this process, a numerical estimate of the difference in predicted and original responses is done, also called the training error. However, this only gives us an idea about how well our model does on data used to train it. 

So, the problem with this evaluation technique is that it does not give an indication of how well the learner will generalize to an independent/ unseen data set. Getting this idea about our model is known as Cross Validation.

This can help the following scenarios:
1. Use All Your Data
2. Get More Metrics
3. Use Models Stacking
4.  Work with Dependent/Grouped Data

	a. Speech: User

	b. Oscar: Year/ type
5. Parameters Fine-Tuning


There are some strategizes 
* K-fold validation
    * Split the data into k subsets or folds 
    * for every i = 1, 2, 3, ... k
        * Train the model on all the folds except the ith.
        * Compute the test error on the ith fold.
    * Average the test error
        
* Leave 1 or K out validation
    * for every i = 1, 2, 3, ... n
        * Train the model on all the data except the ith.
        * Compute the test error on the ith single value.
    * Average the test error 

* Validation set

    *. Split the data into two parts
    *. Train the model the first part, and test or validate on second part.

## Q14- How do you ensure you’re not overfitting with a model?
More reading: How can I avoid overfitting? (Quora)

This is a simple restatement of a fundamental problem in machine learning: the possibility of overfitting training data and carrying the noise of that data through to the test set, thereby providing inaccurate generalizations.
There are three main methods to avoid overfitting:

1. Keep the model simpler: reduce variance by taking into account fewer variables and parameters, thereby removing some of the noise in the training data.
2. Use cross-validation techniques such as k-folds cross-validation.
3. Use regularization techniques such as LASSO that penalize certain model parameters if they’re likely to cause overfitting.

## Q15- How would you handle an imbalanced dataset?

More reading: 8 Tactics to Combat Imbalanced Classes in Your Machine Learning Dataset (Machine Learning Mastery)

An imbalanced dataset is when you have, for example, a classification test and 90% of the data is in one class. That leads to problems: an accuracy of 90% can be skewed if you have no predictive power on the other category of data! Here are a few tactics to get over the hump:

1. Collect more data to even the imbalances in the dataset.
2. Resample the dataset to correct for imbalances.
3. Try a different algorithm altogether on your dataset.

What’s important here is that you have a keen sense for what damage an unbalanced dataset can cause, and how to balance that.

## Q16- When should you use classification over regression?
More reading: Regression vs Classification (Math StackExchange)


Classification produces discrete values and dataset to strict categories, while regression gives you continuous results that allow you to better distinguish differences between individual points. 

You would use classification over regression if you wanted your results to reflect the belongingness of data points in your dataset to certain explicit categories (ex: If you wanted to know whether a name was male or female rather than just how correlated they were with male and female names.)

## Q17- What’s the F1 score? How would you use it?
More reading: F1 score (Wikipedia)

The F1 score is a measure of a model’s performance. It is a weighted average of the precision and recall of a model, with results tending to 1 being the best, and those tending to 0 being the worst. You would use it in classification tests where true negatives don’t matter much.

## Q18- Which is more important to you– model accuracy, or model performance?
More reading: Accuracy paradox (Wikipedia)

This question tests your grasp of the nuances of machine learning model performance! Machine learning interview questions often look towards the details. There are models with higher accuracy that can perform worse in predictive power — how does that make sense?

Well, it has everything to do with how model accuracy is only a subset of model performance, and at that, a sometimes misleading one. For example, if you wanted to detect fraud in a massive dataset with a sample of millions, a more accurate model would most likely predict no fraud at all if only a vast minority of cases were fraud. However, this would be useless for a predictive model — a model designed to find fraud that asserted there was no fraud at all! Questions like this help you demonstrate that you understand model accuracy isn’t the be-all and end-all of model performance.

## Q19- How is a decision tree pruned?
More reading: Pruning (decision trees)

Pruning is what happens in decision trees when branches that have weak predictive power are removed in order to reduce the complexity of the model and increase the predictive accuracy of a decision tree model. 

Pruning can happen bottom-up and top-down, with approaches such as reduced error pruning and cost complexity pruning.

Reduced error pruning is perhaps the simplest version: replace each node. If it doesn’t decrease predictive accuracy, keep it pruned. While simple, this heuristic actually comes pretty close to an approach that would optimize for maximum accuracy.

## Q20- What’s the difference between a generative and discriminative model?
More reading: What is the difference between a Generative and Discriminative Algorithm? (Stack Overflow)

* A generative model will learn categories of data 
* A discriminative model will simply learn the **distinction** or the boundary between different categories of data. 

Discriminative models will generally outperform generative models on classification tasks.

## Q21- What evaluation approaches would you work to gauge the effectiveness of a machine learning model?
More reading: How to Evaluate Machine Learning Algorithms (Machine Learning Mastery)

You would first split the dataset into training and test sets, or perhaps use cross-validation techniques to further segment the dataset into composite sets of training and test sets within the data. 

You should then implement a choice selection of performance metrics: here is a fairly comprehensive list. Y

You could use measures such as the F1 score, the accuracy, and the confusion matrix. 

What’s important here is to demonstrate that you understand the nuances of how a model is measured and how to choose the right performance measures for the right situations.

## Q22- How would you evaluate a logistic regression model?
More reading: Evaluating a logistic regression (CrossValidated)

A subsection of the question above. You have to demonstrate an understanding of what the typical goals of a logistic regression are (classification, prediction etc.) and bring up a few examples and use cases.



## Q23. How is KNN different from k-means clustering?
### K-Nearest Neighbors (K-NN)

k-NN is a supervised algorithm used for classification. What this means is that we have some labeled data upfront which we provide to the model for it to understand the dynamics within that data i.e. train. It then uses those learnings to make inferences on the unseen data i.e. test. In the case of classification this labeled data is discrete in nature.

* Decide on your similarity or distance metric.
* Split the original labeled dataset into training and test data.
* Pick an evaluation metric.
* Decide upon the value of k. Here k refers to the number of closest neighbors we will consider while doing the majority voting of target labels.
* Run k-NN a few times, changing k and checking the evaluation measure.
* In each iteration, k neighbors vote, majority vote wins and becomes the ultimate prediction
* Optimize k by picking the one with the best evaluation measure.
* Once you’ve chosen k, use the same training set and now create a new test set with the people’s ages and incomes that you have no labels for, and want to predict.

### k-Means
k-Means is an unsupervised algorithm used for clustering. By unsupervised we mean that we don’t have any labeled data upfront to train the model. Hence the algorithm just relies on the dynamics of the independent features to make inferences on unseen data.
* Initially, randomly pick k centroids/cluster centers. Try to make them near the data but different from one another.
* Then assign each data point to the closest centroid.
* Move the centroids to the average location of the data points assigned to it.

Repeat the preceding two steps until the assignments don’t change, or change very little.

## Q24. When is Ridge regression favorable over Lasso regression?

### Ridge:
Ridge: It is majorly used to prevent over fitting. Since it includes all the features, it is not very useful in case of exorbitantly high features, say in millions, as it will pose computational challenges.
### Lasso
Lasso: Since it provides sparse solutions, it is generally the model of choice (or some variant of this concept) for modelling cases where the features are in millions or more. In such a case, getting a sparse solution is of great computational advantage as the features with zero coefficients can simply be ignored.

Conceptually, we can say, lasso regression (L1) does both variable selection and parameter shrinkage, whereas Ridge regression only does parameter shrinkage and end up including all the coefficients in the model. In presence of correlated variables, ridge regression might be the preferred choice. Also, ridge regression works best in situations where the least square estimates have higher variance. Therefore, it depends on our model objective.

Collinear predictors, small numbers of predictors, and data with subgroups are all good candidates for Ridge regression. 
* LASSO focuses more on creating a sparse model. 
* Ridge creates a robust model.

## Q25. What’s the difference between a generative and discriminative model?
In General, 
	• A Discriminative model models the decision boundary between the classes.
	• A Generative Model explicitly models the actual distribution of each class. 
In final both of them is predicting the conditional probability P(Animal | Features). But Both models learn different probabilities.

![generative-vs-discriminative](../img/generative-vs-discriminative.png "generative-vs-discriminative")

## Q26. What’s the “kernel trick” and how is it useful?

In machine learning, kernel methods are a class of algorithms for pattern analysis, whose best known member is the support vector machine (SVM).

The general task of pattern analysis is to find and study general types of relations (for example clusters, rankings, principal components, correlations, classifications) in datasets. For many algorithms that solve these tasks, the data in raw representation have to be explicitly transformed into feature vector representations via a user-specified feature map:

in contrast, kernel methods require only a user-specified kernel, i.e., a similarity function over pairs of data points in raw representation.
Kernel methods owe their name to the use of kernel functions, which enable them to operate in a high-dimensional, implicit feature space without ever computing the coordinates of the data in that space, but rather by simply computing the inner products between the images of all pairs of data in the feature space. 

This operation is often computationally cheaper than the explicit computation of the coordinates. This approach is called the "kernel trick".[1] Kernel functions have been introduced for sequence data, graphs, text, images, as well as vectors.

## Q27. What is Time Series Analysis/Forecasting?
Time series analysis comprises methods for analyzing time series data in order to extract meaningful statistics and other characteristics of the data.

Time series forecasting is the use of a model to predict future values based on previously observed values.

## Q28. Mention the difference between Data Mining and Machine learning?

Machine learning relates with the study, design and development of the algorithms that give computers the capability to learn without being explicitly programmed.  

While, data mining can be defined as the process in which the unstructured data tries to extract knowledge or unknown interesting patterns.  During this process machine, learning algorithms are used.

## Q29. What is ‘Overfitting’ in Machine learning?

In machine learning, when a statistical model describes random error or noise instead of underlying relationship ‘overfitting’ occurs.  When a model is excessively complex, overfitting is normally observed, because of having too many parameters with respect to the number of training data types. The model exhibits poor performance which has been overfit.
## Q30.fitting happens?
The possibility of overfitting exists as the criteria used for training the model is not the same as the criteria used to judge the efficacy of a model.


## Q31.  What is ‘Training set’ and ‘Test set’?

In various areas of information science like machine learning, a set of data is used to discover the potentially predictive relationship known as ‘Training Set’.

Training set is an examples given to the learner, while Test set is used to test the accuracy of the hypotheses generated by the learner, and it is the set of example held back from the learner. Training set are distinct from Test set.

## Q32. Explain what is the function of ‘Unsupervised Learning’?
* Find clusters of the data
* Find low-dimensional representations of the data
* Find interesting directions in data
* Interesting coordinates and correlations
* Find novel observations/ database cleaning

## Q33.    Explain what is the function of ‘Supervised Learning’?
* Classifications
* Speech recognition
* Regression
* Predict time series
* Annotate strings

## Q34. What is classifier in machine learning?

A classifier in a Machine Learning is a system that inputs a vector of discrete or continuous feature values and outputs a single discrete value, the class.

## Q35.  What are the advantages of Naive Bayes?
In Naïve Bayes classifier will converge quicker than discriminative models like logistic regression, so you need less training data.  The main dis-advantage is that it can’t learn interactions between features.

## Q36. What is Model Selection in Machine Learning?
The process of selecting models among different mathematical models, which are used to describe the same data set is known as Model Selection. Model selection is applied to the fields of statistics, machine learning and data mining.

## Q37.  What is ensemble learning?

To solve a particular computational program, multiple models such as classifiers or experts are strategically generated and combined. This process is known as ensemble learning.

## Q38.   Why ensemble learning is used?
Ensemble learning is used to improve the classification, prediction, function approximation etc of a model.

## Q39. When to use ensemble learning?

Ensemble learning is used when you build component classifiers that are more accurate and independent from each other.