def rate(bob_scores: list[int], alice_scores: list[int]):
    alice_rating = 0; bob_rating = 0
    
    length = min(len(bob_scores), len(alice_scores))

    for i in range(length):
        if alice_scores[i] > bob_scores[i]: alice_rating += 1
        elif bob_scores[i] > alice_scores[i]: bob_rating += 1
    #
    
    flip = lambda x, y: (y, x)
    
    return flip(alice_rating, bob_rating)
#
