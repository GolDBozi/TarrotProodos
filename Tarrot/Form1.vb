Imports vb = Microsoft.VisualBasic

Public Class Form1
    Private str, str1, onoma As String
    Private a, a1, b, c As Integer
    Dim random1, random2, random3 As Byte
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'entoles gia to 1to koumpi 

        Randomize()
        random1 = (Rnd() * 9) + 1

        If random1 = 1 Then

            'For b = 0 To 10
            '    Me.PictureBox1.Size = New Size(PictureBox1.Size.Width - 2, PictureBox1.Size.Height)
            '    Me.PictureBox1.Location = New Point(PictureBox1.Location.X + 1, PictureBox1.Location.Y)
            '    Refresh()

            'Next
            'If (b = 0) Then
            '    Me.PictureBox1.BackgroundImage = (My.Resources._11)
            '    b = 1
            'Else
            '    PictureBox1.Image = My.Resources._1
            '    b = 0

            'End If

            'For b = 0 To 10
            '    Me.PictureBox1.Size = New Size(PictureBox1.Size.Width + 2, PictureBox1.Size.Height)
            '    Me.PictureBox1.Location = New Point(PictureBox1.Location.X - 1, PictureBox1.Location.Y)
            '    Refresh()
            'Next
            PictureBox1.Image = My.Resources._1
            Dim z As String = "Συμβολίζει πολλές δύσκολες αποφάσεις που ταυτόχρονα σας καθοδηγούν σε καλό και κακό αποτέλεσμα.Θα σας παρουσιαστεί μια από φαση η οποία θα δοκιμάσει τις αξίες σας,θα είναι απόφαση μεταξύ καριέρας και αγάπης.Κανένα δεν θα χαθεί για πάντα όμως αυτή η επιλογή θα διαμορφώσει τις προτεραιότητές σας."
            str = z
            a = Len(str) + 1
            a = 1
            ' TextBox1.Text = z

        End If
        If random1 = 2 Then

            'For b = 0 To 10
            '    Me.PictureBox1.Size = New Size(PictureBox1.Size.Width - 2, PictureBox1.Size.Height)
            '    Me.PictureBox1.Location = New Point(PictureBox1.Location.X + 1, PictureBox1.Location.Y)
            '    Refresh()

            'Next
            'If (b = 0) Then
            '    Me.PictureBox1.BackgroundImage = (My.Resources._11)
            '    b = 1
            'Else
            '    PictureBox1.Image = My.Resources._2
            '    b = 0

            'End If

            'For b = 0 To 10
            '    Me.PictureBox1.Size = New Size(PictureBox1.Size.Width + 2, PictureBox1.Size.Height)
            '    Me.PictureBox1.Location = New Point(PictureBox1.Location.X - 1, PictureBox1.Location.Y)
            '    Refresh()
            'Next
            PictureBox1.Image = My.Resources._2
            Dim y As String = "Αποτελεί μια καινούργια αρχή και ταυτόχρονα το τέλος σε κάτι από την παλιά σας ζωή.Αποδέχεστε την κάθε περιπέτεια όπως έρχεται και είστε πάντα αιδιόδοξοι."
            ' TextBox1.Text = y
            str = y
            a = Len(str) + 1
            a = 1
        End If
        If random1 = 3 Then

            'For b = 0 To 10
            '    Me.PictureBox1.Size = New Size(PictureBox1.Size.Width - 2, PictureBox1.Size.Height)
            '    Me.PictureBox1.Location = New Point(PictureBox1.Location.X + 1, PictureBox1.Location.Y)
            '    Refresh()

            'Next
            'If (b = 0) Then
            '    Me.PictureBox1.BackgroundImage = (My.Resources._11)
            '    b = 1
            'Else
            '    PictureBox1.Image = My.Resources._3
            '    b = 0

            'End If

            'For b = 0 To 10
            '    Me.PictureBox1.Size = New Size(PictureBox1.Size.Width + 2, PictureBox1.Size.Height)
            '    Me.PictureBox1.Location = New Point(PictureBox1.Location.X - 1, PictureBox1.Location.Y)
            '    Refresh()
            'Next
            PictureBox1.Image = My.Resources._3
            Dim w As String = "Δεν υπάρχει σιγουριά στη ζωή σας εκτός από την αβεβαιότητα,κάθε στιγμή είναι και μια καινούργια αρχή,όταν η ευκαιρία σας χτυπά την πόρτα ανοίξτε την διάπλατα."
            '  TextBox1.Text = w
            str = w
            a = Len(str) + 1
            a = 1
        End If
        If random1 = 4 Then

            '    For b = 0 To 10
            '        Me.PictureBox1.Size = New Size(PictureBox1.Size.Width - 2, PictureBox1.Size.Height)
            '        Me.PictureBox1.Location = New Point(PictureBox1.Location.X + 1, PictureBox1.Location.Y)
            '        Refresh()

            '    Next
            '    If (b = 0) Then
            '        Me.PictureBox1.BackgroundImage = (My.Resources._11)
            '        b = 1
            '    Else
            '        PictureBox1.Image = My.Resources._4
            '        b = 0

            '    End If

            '    For b = 0 To 10
            '        Me.PictureBox1.Size = New Size(PictureBox1.Size.Width + 2, PictureBox1.Size.Height)
            '        Me.PictureBox1.Location = New Point(PictureBox1.Location.X - 1, PictureBox1.Location.Y)
            '        Refresh()
            '    Next

            PictureBox1.Image = My.Resources._4
            Dim x As String = "Αναζήτηση της εσωτερικής σοφίας για την αλήθεια πάση θυσία,η επιθυμία για απομόνωση.Έχει έρθει η στιγμή να κάνετε μια ανασκόπηση των επιλογών που έχετε επιλέξει μέχρι τώρα."
            ' TextBox1.Text = x
            str = x
            a = Len(str) + 1
            a = 1
        End If
        If random1 = 5 Then

            'For b = 0 To 10
            '    Me.PictureBox1.Size = New Size(PictureBox1.Size.Width - 2, PictureBox1.Size.Height)
            '    Me.PictureBox1.Location = New Point(PictureBox1.Location.X + 1, PictureBox1.Location.Y)
            '    Refresh()

            'Next
            'If (b = 0) Then
            '    Me.PictureBox1.BackgroundImage = (My.Resources._11)
            '    b = 1
            'Else
            '    PictureBox1.Image = My.Resources._5
            '    b = 0

            'End If

            'For b = 0 To 10
            '    Me.PictureBox1.Size = New Size(PictureBox1.Size.Width + 2, PictureBox1.Size.Height)
            '    Me.PictureBox1.Location = New Point(PictureBox1.Location.X - 1, PictureBox1.Location.Y)
            '    Refresh()
            'Next
            PictureBox1.Image = My.Resources._5
            Dim q As String = "Αφορά μια αλλαγή που θα γίνει στη ζωή σας,η αλλαγή αυτή θα ειναι μόνιμη,σημαντική και απόλυτη θα τελειώσει ένας παλιός κύκλος και θα αρχίσει ένας νέος.Παρόλο που θα πονέσει ο Θάνατος έχει μια σημαντική θέση στον κύκλο της ζωής."
            '  TextBox1.Text = q
            str = q
            a = Len(str) + 1
            a = 1
        End If
        If random1 = 6 Then

            'For b = 0 To 10
            '    Me.PictureBox1.Size = New Size(PictureBox1.Size.Width - 2, PictureBox1.Size.Height)
            '    Me.PictureBox1.Location = New Point(PictureBox1.Location.X + 1, PictureBox1.Location.Y)
            '    Refresh()

            'Next
            'If (b = 0) Then
            '    Me.PictureBox1.BackgroundImage = (My.Resources._11)
            '    b = 1
            'Else
            '    PictureBox1.Image = My.Resources._6
            '    b = 0

            'End If

            'For b = 0 To 10
            '    Me.PictureBox1.Size = New Size(PictureBox1.Size.Width + 2, PictureBox1.Size.Height)
            '    Me.PictureBox1.Location = New Point(PictureBox1.Location.X - 1, PictureBox1.Location.Y)
            '    Refresh()
            'Next
            PictureBox1.Image = My.Resources._6
            Dim v As String = "Αν είσασταν δίκαιοι και καλοί απέναντι στους άλλους θα εισπράξετε κάποια συμβουλή ή κάποιο δώρο αν είσασταν άδικοι καταχρηστικοί ή ανήθικοι αυτό είναι μια προειδοποίηση να αλλάξετε τους τρόπους σας πριν τιμωρηθείτε"
            '  TextBox1.Text = v
            str = v
            a = Len(str) + 1
            a = 1
        End If
        If random1 = 7 Then
            PictureBox1.Image = My.Resources._7
            Dim i As String = "Η παρούσα στιγμή θα σου φερει ολοκλήρωση για κάποια ευχή ή η επιθυμία για αλλαγή σκηνικού.Για να βρεις ικανοποίηση πρέπει να αποδεχτείς τις ιδέες των άλλων να είναι ισάξιες με τις δικές σου. Είναι η αίσθηση της εσωτερικής ισορροπίας και βαθύτερης κατανόησης."
            str = i
            a = Len(str) + 1
            a = 1
        End If

        If random1 = 8 Then
            PictureBox1.Image = My.Resources._8
            Dim o As String = "Να θυμάστε ότι η πράξη του να δίνεις βοήθεια,είναι πιο σημαντική από το πρόσωπο που βοηθάτε.Η καθε αλλαγή είναι ενας μικρός θάνατος,όπως όταν πρέπει να πεθάνει το παλιό για να δημιουργηθεί το καινούργιο.Πρέπει να δώσετε σημασία στις αποφάσεις σας."
            str = o
            a = Len(str) + 1
            a = 1
        End If
        If random1 = 9 Then
            PictureBox1.Image = My.Resources._9
            Dim p As String = "Υπάρχει ένα γεγονός πέραν της επιρροής σας που θα σας αλλάξει την ζωή.Δεν είναι σίγουρο αν είναι καλό ή οχι,αλλά  αποφύγετε τις υπερβολικές συμπεριφορές και μείνετε πιστοί στον εαυτό σας.Είναι η προειδοποίηση για μια αναπόφευκτη κατάσταση αλλά δεν εγγυάται την αποφυγή της. "
            str = p
            a = Len(str) + 1
            a = 1
        End If
        If random1 = 10 Then
            PictureBox1.Image = My.Resources._10
            Dim k As String = "Υπάρχει η πιθανότητα για μια καινούργια φιλία ή σχέση ,η οποία θα σε οδηγήσει σε ευτυχία και ικανοποίηση,μην τα παρατήσεις και θα οδηγηθείς σε επιτυχία. "
            str = k
            a = Len(str) + 1
            a = 1
        End If
        'kruvei to prwto koumpi kai emfanizei to deutero
        Timer1.Enabled = True
        ' PictureBox1.Visible = True

        Button2.Visible = True
        PictureBox2.Visible = True
        PictureBox2.Image = My.Resources._11
        Label5.Visible = True
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
        'kalwsorisma  kruvei to koumpi kai emfanizei to epomeno gia to onoma
        Dim greeting As String = "Καλησπέρα γήινο Ον καλωσήρθες στο Totally Serious Tarot .Είσαι προετοιμασμένο για να μάθεις τι σου επιφυλάσει η  μοίρα???"
        TextBox4.Text = greeting
        Button3.Visible = False
        Button5.Visible = True

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mpainei mousikh
        My.Computer.Audio.Play(My.Resources.NarutoShippuden_Pain, AudioPlayMode.BackgroundLoop)
        b = 0
        c = 0
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        'an einai keno na mhn emfanistei to koumpi
        If TextBox3.Text = (vbEmpty).ToString Then
            Button4.Visible = False

        Else
            Button4.Visible = True
        End If
    End Sub

    Public Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'an einai keno to pedio na emfanisei munhma oti dn mporei na proxwrhsh
        'na krupsei ta sxetika tou onomatos na emfanisei ta sxetika ths hlikias
        If TextBox3.Text = (Text.Empty) Then
            MessageBox.Show("Είσαι τόσο ασήμαντο που δεν έχεις καν όνομα?Muahaha", "Έσφαλες ανίδεο Ον")
        Else
            Button4.Visible = False
                Label1.Visible = False
                Label2.Visible = True
                TextBox3.Visible = False
            TextBox5.Visible = True
            Panel1.BackgroundImage = My.Resources.panelback
        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'emfanizei ta sxetika tou onomatos
        TextBox3.Visible = True
        Label1.Visible = True
        TextBox4.Visible = False
        Button5.Visible = False
        Panel1.BackgroundImage = My.Resources.panelback2
        PictureBox3.Visible = False
        PictureBox4.Visible = False


    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'edw ta sxetika gia to koumpi 2 idio me to prwto sxedon
        Randomize()
        random2 = (Rnd() * 9) + 1
        Do While random2 = random1

            random2 = (Rnd() * 9) + 1
        Loop
        If random2 = 1 And random1 <> 1 Then
            PictureBox2.Image = My.Resources._1
            Dim z As String = "Να γίνεται πάντα μια επιλογή,να γνωρίζεται τι είναι σωστό για εσάς προσωπικά,να ξέρετε ότι τα αντίθετα είναι οι δύο όψεις του ίδιου νομίσματος,δεν υπάρχει το ένα χωρίς το άλλο,η σωστή επιλογή θα γίνει μόνο αν αποδεχτείτε τους άλλους και τον εαυτό σας."
            'TextBox2.Text = z
            str1 = z
            a1 = Len(str1) + 1
            a1 = 1
        End If
        If random2 = 2 And random1 <> 2 Then
            PictureBox2.Image = My.Resources._2
            Dim y As String = "Βαδίζεται στο δρόμο της προσωπικής σας αναζήτησης, αυθόρμητα ξεκινάτε για το άγνωστο θέλετε να πετύχετε το πιο θετικό αποτέλεσμα και είστε πάντα αισιόδοξοι όταν αντιμετωπίζετε αλλαγές."
            'TextBox2.Text = y
            str1 = y
            a1 = Len(str1) + 1
            a1 = 1
        End If
        If random2 = 3 And random1 <> 3 Then
            PictureBox2.Image = My.Resources._3
            Dim w As String = "Απρόβλεπτα γεγονότα που θα σας συμβούν πρέπει να τα εκμεταλλευτείτε.Αλλά αφού είναι θέμα τύχης  μην επικεντρώνεστε σε θέματα που δεν μπορείτε να ελέξετε."
            ' TextBox2.Text = w
            str1 = w
            a1 = Len(str1) + 1
            a1 = 1
        End If
        If random2 = 4 And random1 <> 4 Then
            PictureBox2.Image = My.Resources._4
            Dim x As String = "Αναζήτηση κατεύθυνσης ή καθοδήγησης όταν καταλάβετε τον πραγματικό δρόμο μπροστά σας δεν θα μπορεί να σας σταθεί τίποτα εμπόδιο,η ζωή,σας έχει προκαλέσει αλλά εσείς είστε προετοιμασμένοι για να κάνετε το μέλλον σας καλύτερο."
            ' TextBox2.Text = x
            str1 = x
            a1 = Len(str1) + 1
            a1 = 1
        End If
        If random2 = 5 And random1 <> 5 Then
            PictureBox2.Image = My.Resources._5
            Dim q As String = "Αποδοχή του κύκλου της αλλαγής για να μπορείτε να συνεχίσετε να κινήστε μπροστά και θα δείτε ότι οι αλλαγές θα γίνονται πιο εύκολα αν τις αποδεχθείτε από το να αντιστέκεστε.Το παρελθόν είναι πίσω σας και η ζωή σας συνεχίζει γι'αυτό σνεχίστε το ταξίδι σας με όλο σας το είναι."
            ' TextBox2.Text = q
            str1 = q
            a1 = Len(str1) + 1
            a1 = 1
        End If
        If random2 = 6 And random1 <> 6 Then
            PictureBox2.Image = My.Resources._6
            Dim v As String = "Όταν όλα ξεκαθαρίσουν θα ειπράξετε  αυτό που σας αξίζει.Ο χαρακτήρας σας θα είναι δικαιωμένος γι'αυτό προσπαθήστε να ισορροπήσετε τον εαυτό σας.Κοιτάξτε την κάθε οπτική ενός ζητήματος."
            ' TextBox2.Text = v
            str1 = v
            a1 = Len(str1) + 1
            a1 = 1
        End If
        If random2 = 7 And random1 <> 7 Then
            PictureBox2.Image = My.Resources._7
            Dim n As String = "Πρέπει να βρεις το στόχο σου και να τον ολοκληρώσεις.Το ίδιο και με τα όνειρα πρέπει πρώτα να ξέρεις πια είναι για να τα πραγματοποιήσεις.Δεν υπάρχει εγγύηση για επιτυχία αλλά η εμπειρία που θα πάρεις θα έχει την προοπτική να σου γεμίσει τις επιθυμίες."
            ' TextBox2.Text = v
            str1 = n
            a1 = Len(str1) + 1
            a1 = 1
        End If
        If random2 = 8 And random1 <> 8 Then
            PictureBox2.Image = My.Resources._8
            Dim m As String = "Υπάρχουν πολλά άγνωστα πράγματα για εσάς γι'αυτό πρέπει να δημιουργείτε νέους στόχους και να σχεδιάζετε προσεκτικά.Δρώντας τη σωστή στιγμή θα σας ωφελήσει,αλλά προσέξτε διότι δεν μπορείτε να επιστρέψετε από τις αποφάσεις σας. "
            ' TextBox2.Text = v
            str1 = m
            a1 = Len(str1) + 1
            a1 = 1
        End If
        If random2 = 9 And random1 <> 9 Then
            PictureBox2.Image = My.Resources._9
            Dim g As String = "Έρχεται η ώρα να βρείτε την ομορφιά μέσα σας και να βρείτε το θάρος να αλλάξετε την ζωή σας.Η διαδρομή της ζωή σας είναι άγνωστη,αλλά αυτή η επίγνωση  θα νικήσει τις αυταπάτες σας."
            ' TextBox2.Text = v
            str1 = g
            a1 = Len(str1) + 1
            a1 = 1
        End If
        If random2 = 10 And random1 <> 10 Then
            PictureBox2.Image = My.Resources._10
            Dim d As String = "Θα φτάσεις σε μια στιγμή η οποία μπορεί να αλλάξει τη ζωή σου.Εκμεταλεύσου το αυτή τη φορά και θα οδηγηθείς σε ένα μέλλον με ατελείωτες πιθανότητες.Αν ξεκινάς ένα προσωπικό  ταξίδι όπως  γάμος ή οικογένεια,ο Ήλιος είναι ιδιαίτερη επιρροή."
            ' TextBox2.Text = v
            str1 = d
            a1 = Len(str1) + 1
            a1 = 1
        End If

        'emfanizei thn eikona kai to keimeno kai emfanizei ta exit kai replay buttons kai ksekinaei to timer
        'PictureBox2.Visible = True
        Timer2.Enabled = True
        Label3.Visible = True
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
        'maggia otan kleinei na kleisei me fadeout
        For FadeOut = 90 To 10 Step -5
            Me.Opacity = FadeOut / 100
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next
        End

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'replay koumpi kruvei ta prohgoumena kai emfanizei to 1 koumpi gia thn karta
        Randomize()
        random3 = (Rnd() * 3) + 1
        If random3 = 1 Then
            Me.BackgroundImage = My.Resources.bg1
        End If
        If random3 = 2 Then
            Me.BackgroundImage = My.Resources.bg2
        End If

        If random3 = 3 Then
            Me.BackgroundImage = My.Resources.bg3
        End If
        If random3 = 4 Then
            Me.BackgroundImage = My.Resources.bg4
        End If

        PictureBox1.Image = My.Resources._11
        PictureBox2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        Button2.Visible = False
        Button1.Visible = True
        Button6.Visible = False
        Button7.Visible = False
        Label5.Visible = False
        Label3.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'an den valei ilikia skaei error kai otan valei mpainei sto komati tou riksimatos 

        If TextBox5.Text = (Text.Empty) Then
            MessageBox.Show("Δεν υπάρχεις!!!", "Έσφαλες ανίδεο Ον")

        Else
            Dim age As Double = (TextBox5.Text)
            If age > 99 Then
                MessageBox.Show("Μητσοτάκη εσύ???Σε περίμενα!Muahaha", "Έσφαλες ανίδεο Ον")

            Else
                Button4.Visible = False
                Label1.Visible = False
                Label2.Visible = True
                Panel1.Visible = False

            End If
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        'an einai adeio na mhn emfanistei to koumpi 
        If TextBox5.Text = (vbEmpty).ToString Then
            Button8.Visible = False
        Else
            Button8.Visible = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'timer 1 entoles
        TextBox1.Text = vb.Left(str, a)
        a = a + 1


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'timer 2 entoles
        TextBox2.Text = vb.Left(str1, a1)
        a1 = a1 + 1

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        MessageBox.Show("Georgi Grigorov" & vbNewLine & "Τεχνικός Λογισμικού " & vbNewLine & "Λογισμ Γ1 " & vbNewLine & "ΙΕΚ Ακμή 2016 ", "Programmer")

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        MessageBox.Show("Κανείς δεν είναι σε θέση να γνωρίζει την ακριβή προέλευσή τους, αφού η ιστορία τους χάνεται στα βάθη των αιώνων, ωστόσο είναι αρκετές και μάλιστα ενδιαφέρουσες οι θεωρίες για το πώς προέκυψε η ονομασία τους. Στις περισσότερες ξένες γλώσσες ονομάζονται Tarot, ενώ στα Ιταλικά Tarocco. Σύμφωνα με μια θεωρία, το όνομά τους έχει τις ρίζες του στα βυζαντινά χρόνια. Όσοι συμβουλεύονταν τα συγκεκριμένα χαρτιά έλεγαν ότι «τα ρωτούν». Οι Φράγκοι ακούγοντάς τους να λένε «Τα ρωτώ», θεώρησαν ότι αυτό ήταν το όνομα της τράπουλας και κάπως έτσι προέκυψε το γαλλικό Tarot, ενώ οι Βενετσιάνοι το προσάρμοσαν στη δική τους γλώσσα με αποτέλεσμα να δημιουργηθεί η ονομασία Tarocco, ενώ τα χαρτιά της τράπουλας αναφέρονται ως Tarocchi.
Σύμφωνα με άλλες θεωρίες η ονομασία τους προέρχεται από το αιγυπτιακό ta-rosh, που σημαίνει «ο βασιλικός δρόμος», από τον αναγραμματισμό του ιταλικού «rota», αλλά και από τον νόμο της εβραϊκής Καμπάλα, την Τόρα. Ιδιαίτερο ενδιαφέρον παρουσιάζει η θεωρία που λέει ότι τα Ταρώ ξεκίνησαν από την Κίνα, όπου εφευρέθηκε και η τυπογραφία. Από εκεί πέρασαν στην Ινδία και αργότερα στην Ευρώπη. Τέλος, πολλοί είναι αυτοί που πιστεύουν ότι συνδέονται με την Ινδία, μιας και υπάρχει αντιστοιχία της εικοστής πρώτης κάρτας της Μεγάλης Αρκάνας, που λέγεται «ο Κόσμος», με την βουδιστική «μαντάλα».Οι κάρτες Ταρώ αποτελούν τον συνδετικό κρίκο ανάμεσα στον υλικό και τον πνευματικό κόσμο. Αυτός που θα ασχοληθεί με τη μελέτη τους θα είναι σε θέση να ανακαλύψει βαθύτερα νοήματα πέρα από το προφανές. Ο καθένας από εμάς μπορεί να ασχοληθεί μαζί τους και να τα μελετήσει, αλλά η πραγματική γνώση και η βαθιά ενασχόληση θα έρθει μόνο για τους πραγματικά προικισμένους, για εκείνους που έχουν ψυχικές ικανότητες που είναι ανοιχτοί να αντιληφθούν τη σοφία αυτής της πανάρχαιης τέχνης.", "Tarot")
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        MessageBox.Show("Τα πνευματικά δικαιώματα για όλες τις εικόνες και μουσικές που χρησιμοποιούνται σ'αυτό το πρόγραμμα ανήκουν στους αυθεντικούς κατόχους τους.Αυτό το πρόγραμμα δημιουργήθηκε για μια σχολική εργασία και δεν πρόκειται να χρησιμοποιηθεί για χρηματικούς σκοπούς.  ", "Copyright")
    End Sub
    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        'entoles gia to 1to koumpi 
        Randomize()
        random1 = (Rnd() * 9) + 1
        If random1 = 1 And random2 <> 1 Then
            PictureBox1.Image = My.Resources._1
            Dim z As String = "Συμβολίζει πολλές δύσκολες αποφάσεις που ταυτόχρονα σας καθοδηγούν σε καλό και κακό αποτέλεσμα.Θα σας παρουσιαστεί μια από φαση η οποία θα δοκιμάσει τις αξίες σας,θα είναι απόφαση μεταξύ καριέρας και αγάπης.Κανένα δεν θα χαθεί για πάντα όμως αυτή η επιλογή θα διαμορφώσει τις προτεραιότητές σας."
            str = z
            a = Len(str) + 1
            a = 1
        End If
        If random1 = 2 And random2 <> 2 Then
            PictureBox1.Image = My.Resources._2
            Dim y As String = "Αποτελεί μια καινούργια αρχή και ταυτόχρονα το τέλος σε κάτι από την παλιά σας ζωή.Αποδέχεστε την κάθε περιπέτεια όπως έρχεται και είστε πάντα αιδιόδοξοι."
            str = y
            a = Len(str) + 1
            a = 1
        End If
        If random1 = 3 And random2 <> 3 Then
            PictureBox1.Image = My.Resources._3
            Dim w As String = "Δεν υπάρχει σιγουριά στη ζωή σας εκτός από την αβεβαιότητα,κάθε στιγμή είναι και μια καινούργια αρχή,όταν η ευκαιρία σας χτυπά την πόρτα ανοίξτε την διάπλατα."
            str = w
            a = Len(str) + 1
            a = 1
        End If
        If random1 = 4 And random2 <> 4 Then
            PictureBox1.Image = My.Resources._4
            Dim x As String = "Αναζήτηση της εσωτερικής σοφίας για την αλήθεια πάση θυσία,η επιθυμία για απομόνωση.Έχει έρθει η στιγμή να κάνετε μια ανασκόπηση των επιλογών που έχετε επιλέξει μέχρι τώρα."

            str = x
            a = Len(str) + 1
            a = 1
        End If
        If random1 = 5 And random2 <> 5 Then
            PictureBox1.Image = My.Resources._5
            Dim q As String = "Αφορά μια αλλαγή που θα γίνει στη ζωή σας,η αλλαγή αυτή θα ειναι μόνιμη,σημαντική και απόλυτη θα τελειώσει ένας παλιός κύκλος και θα αρχίσει ένας νέος.Παρόλο που θα πονέσει ο Θάνατος έχει μια σημαντική θέση στον κύκλο της ζωής."
            str = q
            a = Len(str) + 1
            a = 1
        End If
        If random1 = 6 And random2 <> 6 Then
            PictureBox1.Image = My.Resources._6
            Dim v As String = "Αν είσασταν δίκαιοι και καλοί απέναντι στους άλλους θα εισπράξετε κάποια συμβουλή ή κάποιο δώρο αν είσασταν άδικοι καταχρηστικοί ή ανήθικοι αυτό είναι μια προειδοποίηση να αλλάξετε τους τρόπους σας πριν τιμωρηθείτε"
            str = v
            a = Len(str) + 1
            a = 1
        End If
        If random1 = 7 And random2 <> 7 Then
            PictureBox1.Image = My.Resources._7
            Dim i As String = "Η παρούσα στιγμή θα σου φερει ολοκλήρωση για κάποια ευχή ή η επιθυμία για αλλαγή σκηνικού.Για να βρεις ικανοποίηση πρέπει να αποδεχτείς τις ιδέες των άλλων να είναι ισάξιες με τις δικές σου. Είναι η αίσθηση της εσωτερικής ισορροπίας και βαθύτερης κατανόησης."
            str = i
            a = Len(str) + 1
            a = 1
        End If

        If random1 = 8 And random2 <> 8 Then
            PictureBox1.Image = My.Resources._8
            Dim o As String = "Να θυμάστε ότι η πράξη του να δίνεις βοήθεια,είναι πιο σημαντική από το πρόσωπο που βοηθάτε.Η καθε αλλαγή είναι ενας μικρός θάνατος,όπως όταν πρέπει να πεθάνει το παλιό για να δημιουργηθεί το καινούργιο.Πρέπει να δώσετε σημασία στις αποφάσεις σας."
            str = o
            a = Len(str) + 1
            a = 1
        End If
        If random1 = 9 And random2 <> 9 Then
            PictureBox1.Image = My.Resources._9
            Dim p As String = "Υπάρχει ένα γεγονός πέραν της επιρροής σας που θα σας αλλάξει την ζωή.Δεν είναι σίγουρο αν είναι καλό ή οχι,αλλά  αποφύγετε τις υπερβολικές συμπεριφορές και μείνετε πιστοί στον εαυτό σας.Είναι η προειδοποίηση για μια αναπόφευκτη κατάσταση αλλά δεν εγγυάται την αποφυγή της. "
            str = p
            a = Len(str) + 1
            a = 1
        End If
        If random1 = 10 And random2 <> 10 Then
            PictureBox1.Image = My.Resources._10
            Dim k As String = "Υπάρχει η πιθανότητα για μια καινούργια φιλία ή σχέση ,η οποία θα σε οδηγήσει σε ευτυχία και ικανοποίηση,μην τα παρατήσεις και θα οδηγηθείς σε επιτυχία. "
            str = k
            a = Len(str) + 1
            a = 1
        End If
        'kruvei to prwto koumpi kai emfanizei to deutero
        Timer1.Enabled = True
        ' PictureBox1.Visible = True
        Button2.Visible = True
        PictureBox2.Visible = True
        PictureBox2.Image = My.Resources._11
        Label5.Visible = True
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

    Private Sub PictureBox2_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox2.DoubleClick
        'edw ta sxetika gia to koumpi 2 idio me to prwto sxedon
        Randomize()
        random2 = (Rnd() * 9) + 1
        Do While random2 = random1
            random2 = (Rnd() * 9) + 1
        Loop
        If random2 = 1 And random1 <> 1 Then
            PictureBox2.Image = My.Resources._1
            Dim z As String = "Να γίνεται πάντα μια επιλογή,να γνωρίζεται τι είναι σωστό για εσάς προσωπικά,να ξέρετε ότι τα αντίθετα είναι οι δύο όψεις του ίδιου νομίσματος,δεν υπάρχει το ένα χωρίς το άλλο,η σωστή επιλογή θα γίνει μόνο αν αποδεχτείτε τους άλλους και τον εαυτό σας."

            str1 = z
            a1 = Len(str1) + 1
            a1 = 1
        End If
        If random2 = 2 And random1 <> 2 Then
            PictureBox2.Image = My.Resources._2
            Dim y As String = "Βαδίζεται στο δρόμο της προσωπικής σας αναζήτησης, αυθόρμητα ξεκινάτε για το άγνωστο θέλετε να πετύχετε το πιο θετικό αποτέλεσμα και είστε πάντα αισιόδοξοι όταν αντιμετωπίζετε αλλαγές."

            str1 = y
            a1 = Len(str1) + 1
            a1 = 1
        End If
        If random2 = 3 And random1 <> 3 Then
            PictureBox2.Image = My.Resources._3
            Dim w As String = "Απρόβλεπτα γεγονότα που θα σας συμβούν πρέπει να τα εκμεταλλευτείτε.Αλλά αφού είναι θέμα τύχης  μην επικεντρώνεστε σε θέματα που δεν μπορείτε να ελέξετε."

            str1 = w
            a1 = Len(str1) + 1
            a1 = 1
        End If
        If random2 = 4 And random1 <> 4 Then
            PictureBox2.Image = My.Resources._4
            Dim x As String = "Αναζήτηση κατεύθυνσης ή καθοδήγησης όταν καταλάβετε τον πραγματικό δρόμο μπροστά σας δεν θα μπορεί να σας σταθεί τίποτα εμπόδιο,η ζωή,σας έχει προκαλέσει αλλά εσείς είστε προετοιμασμένοι για να κάνετε το μέλλον σας καλύτερο."

            str1 = x
            a1 = Len(str1) + 1
            a1 = 1
        End If
        If random2 = 5 And random1 <> 5 Then
            PictureBox2.Image = My.Resources._5
            Dim q As String = "Αποδοχή του κύκλου της αλλαγής για να μπορείτε να συνεχίσετε να κινήστε μπροστά και θα δείτε ότι οι αλλαγές θα γίνονται πιο εύκολα αν τις αποδεχθείτε από το να αντιστέκεστε.Το παρελθόν είναι πίσω σας και η ζωή σας συνεχίζει γι'αυτό σνεχίστε το ταξίδι σας με όλο σας το είναι."

            str1 = q
            a1 = Len(str1) + 1
            a1 = 1
        End If
        If random2 = 6 And random1 <> 6 Then
            PictureBox2.Image = My.Resources._6
            Dim v As String = "Όταν όλα ξεκαθαρίσουν θα ειπράξετε  αυτό που σας αξίζει.Ο χαρακτήρας σας θα είναι δικαιωμένος γι'αυτό προσπαθήστε να ισορροπήσετε τον εαυτό σας.Κοιτάξτε την κάθε οπτική ενός ζητήματος."

            str1 = v
            a1 = Len(str1) + 1
            a1 = 1
        End If
        If random2 = 7 And random1 <> 7 Then
            PictureBox2.Image = My.Resources._7
            Dim n As String = "Πρέπει να βρεις το στόχο σου και να τον ολοκληρώσεις.Το ίδιο και με τα όνειρα πρέπει πρώτα να ξέρεις πια είναι για να τα πραγματοποιήσεις.Δεν υπάρχει εγγύηση για επιτυχία αλλά η εμπειρία που θα πάρεις θα έχει την προοπτική να σου γεμίσει τις επιθυμίες."

            str1 = n
            a1 = Len(str1) + 1
            a1 = 1
        End If
        If random2 = 8 And random1 <> 8 Then
            PictureBox2.Image = My.Resources._8
            Dim m As String = "Υπάρχουν πολλά άγνωστα πράγματα για εσάς γι'αυτό πρέπει να δημιουργείτε νέους στόχους και να σχεδιάζετε προσεκτικά.Δρώντας τη σωστή στιγμή θα σας ωφελήσει,αλλά προσέξτε διότι δεν μπορείτε να επιστρέψετε από τις αποφάσεις σας. "

            str1 = m
            a1 = Len(str1) + 1
            a1 = 1
        End If
        If random2 = 9 And random1 <> 9 Then
            PictureBox2.Image = My.Resources._9
            Dim g As String = "Έρχεται η ώρα να βρείτε την ομορφιά μέσα σας και να βρείτε το θάρος να αλλάξετε την ζωή σας.Η διαδρομή της ζωή σας είναι άγνωστη,αλλά αυτή η επίγνωση  θα νικήσει τις αυταπάτες σας."

            str1 = g
            a1 = Len(str1) + 1
            a1 = 1
        End If
        If random2 = 10 And random1 <> 10 Then
            PictureBox2.Image = My.Resources._10
            Dim d As String = "Θα φτάσεις σε μια στιγμή η οποία μπορεί να αλλάξει τη ζωή σου.Εκμεταλεύσου το αυτή τη φορά και θα οδηγηθείς σε ένα μέλλον με ατελείωτες πιθανότητες.Αν ξεκινάς ένα προσωπικό  ταξίδι όπως  γάμος ή οικογένεια,ο Ήλιος είναι ιδιαίτερη επιρροή."

            str1 = d
            a1 = Len(str1) + 1
            a1 = 1
        End If

        'emfanizei thn eikona kai to keimeno kai emfanizei ta exit kai replay buttons kai ksekinaei to timer

        Timer2.Enabled = True
        Label3.Visible = True
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
End Class
