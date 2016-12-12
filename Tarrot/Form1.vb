Public Class Form1

    Dim random1 As Byte
    Dim random2 As Byte
    Dim onoma As String
    Dim age As Integer


    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Visible = True

        Randomize()
        random1 = (Rnd() * 5) + 1

        If random1 = 1 And random2 <> 1 Then
            PictureBox1.Image = My.Resources._1
            Dim z As String = "Συμβολίζει πολλές δύσκολες αποφάσεις που ταυτόχρονα σας καθοδηγούν σε καλό και κακό αποτέλεσμα.Θα σας παρουσιαστεί μια από φαση η οποία θα δοκιμάσει τις αξίες σας,θα είναι απόφαση μεταξύ καριέρας και αγάπης.Κανένα δεν θα χαθεί για πάντα όμως αυτή η επιλογή θα διαμορφώσει τις προτεραιότητές σας."
            TextBox1.Text = z

        End If
        If random1 = 2 And random2 <> 2 Then
            PictureBox1.Image = My.Resources._2
            Dim y As String = "Αποτελεί μια καινούργια αρχή και ταυτόχρονα το τέλος σε κάτι από την παλιά σας ζωή.Αποδέχεστε την κάθε περιπέτεια όπως έρχεται και είστε πάντα αιδιόδοξοι."
            TextBox1.Text = y
        End If
        If random1 = 3 And random2 <> 3 Then
            PictureBox1.Image = My.Resources._3
            Dim w As String = "Δεν υπάρχει σιγουριά στη ζωή σας εκτός από την αβεβαιότητα,κάθε στιγμή είναι και μια καινούργια αρχή,όταν η ευκαιρία σας χτυπά την πόρτα ανοίξτε την διάπλατα."
            TextBox1.Text = w
        End If
        If random1 = 4 And random2 <> 4 Then
            PictureBox1.Image = My.Resources._4
            Dim x As String = "Αναζήτηση της εσωτερικής σοφίας για την αλήθεια πάση θυσία,η επιθυμία για απομόνωση.Έχει έρθει η στιγμή να κάνετε μια ανασκόπηση των επιλογών που έχετε επιλέξει μέχρι τώρα."
            TextBox1.Text = x
        End If
        If random1 = 5 And random2 <> 5 Then
            PictureBox1.Image = My.Resources._5
            Dim q As String = "Αφορά μια αλλαγή που θα γίνει στη ζωή σας,η αλλαγή αυτή θα ειναι μόνιμη,σημαντική και απόλυτη θα τελειώσει ένας παλιός κύκλος και θα αρχίσει ένας νέος.Παρόλο που θα πονέσει ο Θάνατος έχει μια σημαντική θέση στον κύκλο της ζωής."
            TextBox1.Text = q
        End If
        If random1 = 6 And random2 <> 6 Then
            PictureBox1.Image = My.Resources._6
            Dim v As String = "Αν είσασταν δίκαιοι και καλοί απέναντι στους άλλους θα εισπράξετε κάποια συμβουλή ή κάποιο δώρο αν είσασταν άδικοι καταχρηστικοί ή ανήθικοι αυτό είναι μια προειδοποίηση να αλλάξετε τους τρόπους σας πριν τιμωρηθείτε"
            TextBox1.Text = v
        End If

        PictureBox1.Visible = True

        TextBox1.Visible = True
        If Button2.Visible = False Then
            Button6.Visible = True
            Button7.Visible = True
        Else
            Button6.Visible = False
            Button7.Visible = False
        End If
        Button1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim greeting As String = "Καλησπέρα γήινο Ον καλωσήρθες στο Totally Serious Tarot .Είσαι προετοιμασμένο για να μάθεις τι σου επιφυλάσει η  μοίρα???"
        TextBox4.Text = greeting
        Button3.Visible = False
        Button5.Visible = True

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.OnePiece, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = (vbEmpty).ToString Then
            Button4.Visible = False
        Else
            Button4.Visible = True
        End If
    End Sub

    Public Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox3.Text = (Text.Empty) Then
            MessageBox.Show("Είσαι τόσο ασήμαντο που δεν έχεις καν όνομα?Muahaha", "Έσφαλες ανίδεο Ον")
        Else
            onoma = (TextBox3.Text)
            Button4.Visible = False
            Label1.Visible = False
            Label2.Visible = True
            TextBox3.Visible = False
            TextBox5.Visible = True
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox3.Visible = True
        Label1.Visible = True
        TextBox4.Visible = False
        Button5.Visible = False
    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Randomize()
        random2 = (Rnd() * 5) + 1
        Do While random2 = random1

            random2 = (Rnd() * 5) + 1
        Loop
        If random2 = 1 And random1 <> 1 Then
            PictureBox2.Image = My.Resources._1
            Dim z As String = "Να γίνεται πάντα μια επιλογή,να γνωρίζεται τι είναι σωστό για εσάς προσωπικά,να ξέρετε ότι τα αντίθετα είναι οι δύο όψεις του ίδιου νομίσματος,δεν υπάρχει το ένα χωρίς το άλλο,η σωστή επιλογή θα γίνει μόνο αν αποδεχτείτε τους άλλους και τον εαυτό σας."
            TextBox2.Text = z

        End If
        If random2 = 2 And random1 <> 2 Then
            PictureBox2.Image = My.Resources._2
            Dim y As String = "Βαδίζεται στο δρόμο της προσωπικής σας αναζήτησης, αυθόρμητα ξεκινάτε για το άγνωστο θέλετε να πετύχετε το πιο θετικό αποτέλεσμα και είστε πάντα αισιόδοξοι όταν αντιμετωπίζετε αλλαγές."
            TextBox2.Text = y
        End If
        If random2 = 3 And random1 <> 3 Then
            PictureBox2.Image = My.Resources._3
            Dim w As String = "Απρόβλεπτα γεγονότα που θα σας συμβούν πρέπει να τα εκμεταλλευτείτε.Αλλά αφού είναι θέμα τύχης  μην επικεντρώνεστε σε θέματα που δεν μπορείτε να ελέξετε."
            TextBox2.Text = w
        End If
        If random2 = 4 And random1 <> 4 Then
            PictureBox2.Image = My.Resources._4
            Dim x As String = "Αναζήτηση κατεύθυνσης ή καθοδήγησης όταν καταλάβετε τον πραγματικό δρόμο μπροστά σας δεν θα μπορεί να σας σταθεί τίποτα εμπόδιο,η ζωή,σας έχει προκαλέσει αλλά εσείς είστε προετοιμασμένοι για να κάνετε το μέλλον σας καλύτερο."
            TextBox2.Text = x
        End If
        If random2 = 5 And random1 <> 5 Then
            PictureBox2.Image = My.Resources._5
            Dim q As String = "Αποδοχή του κύκλου της αλλαγής για να μπορείτε να συνεχίσετε να κινήστε μπροστά και θα δείτε ότι οι αλλαγές θα γίνονται πιο εύκολα αν τις αποδεχθείτε από το να αντιστέκεστε.Το παρελθόν είναι πίσω σας και η ζωή σας συνεχίζει γι'αυτό σνεχίστε το ταξίδι σας με όλο σας το είναι."
            TextBox2.Text = q
        End If
        If random2 = 6 And random1 <> 6 Then
            PictureBox2.Image = My.Resources._6
            Dim v As String = "Όταν όλα ξεκαθαρίσουν θα ειπράξετε  αυτό που σας αξίζει.Ο χαρακτήρας σας θα είναι δικαιωμένος γι'αυτό προσπαθήστε να ισορροπήσετε τον εαυτό σας.Κοιτάξτε την κάθε οπτική ενός ζητήματος."
            TextBox2.Text = v
        End If

        PictureBox2.Visible = True

        TextBox2.Visible = True
        If Button1.Visible = False Then
            Button6.Visible = True
            Button7.Visible = True
        Else
            Button6.Visible = False
            Button7.Visible = False
        End If
        Button2.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For FadeOut = 90 To 10 Step -5
            Me.Opacity = FadeOut / 100
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next
        End

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        Button2.Visible = False
        Button1.Visible = True
        Button6.Visible = False
        Button7.Visible = False

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox5.Text = (Text.Empty) Then
            MessageBox.Show("Δεν υπάρχεις!!!", "Έσφαλες ανίδεο Ον")
        Else
            Dim age As Integer = CInt(TextBox5.Text)
            Button4.Visible = False
            Label1.Visible = False
            Label2.Visible = True
            Panel1.Visible = False

        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = (vbEmpty).ToString Then
            Button8.Visible = False
        Else
            Button8.Visible = True
        End If
    End Sub
End Class
