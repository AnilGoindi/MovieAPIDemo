import React from "react";
import { Modal } from "react-bootstrap";

const CreateMovieModel = (props) => {

    return (
        <>
            <Modal show={props.show} onHide={props.handleClose} centered>
                <Modal.Header closeButton>
                    <Modal.Title>Add New Movie</Modal.Title>
                </Modal.Header>

                <Modal.Body>
                    <div>this is body</div>
                </Modal.Body>
            </Modal>
        </>
    )

}

export default CreateMovieModel;